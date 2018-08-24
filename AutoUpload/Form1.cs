using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AutoUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string distPath;
        public static string deployPath;
        public static string StartupPath;
        private void Form1_Load(object sender, EventArgs e)
        {
            StartupPath = Application.StartupPath;//获取项目所在路径
            ReadingSetting();//读取配置文件
        }
        /// <summary>
        /// 命令行执行器
        /// </summary>
        /// <param name="cmdArray">命令行数组</param>
        public static void RunCmd(string[] cmdArray)
        {
            Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //输出信息
            p.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;
            //启动程序
            p.Start();
            //向cmd窗口发送输入信息
            foreach (string cmd in cmdArray)
            {
                p.StandardInput.WriteLine(cmd + "&&exit");
                p.StandardInput.AutoFlush = true;
            }
            //等待程序执行完退出进程
            p.WaitForExit();
            p.Close();
        }
        /// <summary>
        /// 查找文件名是否在免删列表中出现
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="noDeleteItems">免删列表</param>
        /// <returns>若存在则返回true否则为false</returns>
        public Boolean CheckExist(string fileName, ListView.ListViewItemCollection noDeleteItems)
        {
            foreach (ListViewItem item in noDeleteItems)
            {
                if (item.Text == fileName)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 删除部署代码
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="noDeleteItems">勿删名单集合</param>
        public void DeleteFiles(string path, ListView.ListViewItemCollection noDeleteItems)
        {
            List<String> deleteList = new List<string>(); // 记录被删除的文件
            deleteList.Add("delete");
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();
                ListView.ListViewItemCollection items = noDeleteItems;
                foreach (FileSystemInfo file in fileinfo)
                {
                    if (!CheckExist(file.Name, noDeleteItems))//判断文件是可以删的
                    {
                        if (Directory.Exists(file.FullName))//是文件夹
                        {
                            DirectoryInfo directory = new DirectoryInfo(file.FullName);
                            directory.Delete(true);
                        }
                        else//是文件
                        {
                            file.Delete();
                        }
                        deleteList.Add(file.FullName);
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                CreateLog(deleteList);
            }
        }
        /// <summary>
        /// 复制文件(不包含文件夹)
        /// </summary>
        /// <param name="distPath">原文件目录</param>
        /// <param name="deployPath">终点目录</param>
        public void CopyFiles(string distPath, string deployPath)
        {
            List<String> createList = new List<string>(); // 记录被删除的文件
            createList.Add("create");
            try
            {
                DirectoryInfo dir = new DirectoryInfo(distPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();
                foreach (FileSystemInfo file in fileinfo)
                {
                    string _deployPath;
                    if (!Directory.Exists(file.FullName))//是文件
                    {
                        _deployPath = deployPath + "\\" + file.Name;
                        //File.Copy(file.FullName,_deployPath,true);//复制文件使用bat命令
                        createList.Add(_deployPath);
                        if (file.Name == "index.html" && yes404RadioButton.Checked)//检测到当前文件是index并且用于想要生成404文件
                        {
                            _deployPath = deployPath + "\\404.html";
                            File.Copy(file.FullName, _deployPath, true);
                            createList.Add(_deployPath);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                CreateLog(createList);
                //执行文件复制
                string[] cmd_arr = { @"xcopy " + distPath + " " + deployPath + " /s/y/e" };
                RunCmd(cmd_arr);
            }
        }
        /// <summary>
        /// 创建日志文件
        /// </summary>
        /// <param name="list">存储的列表</param>
        public static void CreateLog(List<String> list)
        {
            StreamWriter streamWriter = new StreamWriter(StartupPath+ "\\log.txt",true);
            streamWriter.WriteLine(); //先空一行,方便查阅日志
            DateTime now = DateTime.Now;
            if (list[0] == "delete")//根据第一个数组内容判断是新增操作还是删除操作
            {
                streamWriter.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss") + " 删除文件记录如下");
                list.RemoveAt(0);
            }
            else if (list[0] == "create")
            {
                streamWriter.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss") + " 新增文件记录如下");
                list.RemoveAt(0);
            }
            foreach (String text in list)
            {
                streamWriter.WriteLine(text);
            }
            streamWriter.Close();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string tip = "当前配置信息如下:\r\n" +
                "编译代码目录:\r\n" +
                "        " + distTextBox.Text + "\r\n" +
                "Page仓库目录:\r\n" +
                "        " + deployTextBox.Text + "\r\n" +
                "Git安装目录:\r\n" +
                "        " + gitPathTextBox.Text + "\r\n" +
                "防删文件名单:\r\n" +
                "      ";
            foreach (ListViewItem item in noDeleteListView.Items)
            {
                tip += "  "+(Convert.ToString(item.SubItems[0].Text));
            }
            tip += "\r\n" +
                "使用Git上传:\r\n" +
                "        ";
            if (gitYesRadioButton.Checked)
            {
                tip += "开启\r\n";
            }
            else
            {
                tip += "关闭\r\n";
            }
            tip += "创建404文件:\r\n" +
                "        ";
            if (yes404RadioButton.Checked)
            {
                tip += "开启\r\n";
            }
            else
            {
                tip += "关闭\r\n";
            }
            if (MessageBox.Show(tip, "请确认配置信息!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                distPath = distTextBox.Text;
                deployPath = deployTextBox.Text;
                DeleteFiles(deployTextBox.Text, noDeleteListView.Items);
                CopyFiles(distPath, deployPath);
                //执行git
                if (gitYesRadioButton.Checked)
                {
                    //若不存在git.bat,则自动创建git.bat
                    if (!File.Exists(StartupPath + "\\git.bat"))
                    {
                        StreamWriter streamWriterPath = new StreamWriter(StartupPath + "\\git.bat", false);
                        streamWriterPath.WriteLine("@echo.");
                        streamWriterPath.WriteLine("@echo [0;32m\"Start accept arguments.\"");
                        streamWriterPath.WriteLine("@echo. [0;37m");
                        streamWriterPath.WriteLine("set disk=%1%");
                        streamWriterPath.WriteLine("set deployPath=%2%");
                        streamWriterPath.WriteLine("set msg=%3%");
                        streamWriterPath.WriteLine("set gitPath=%4%");
                        streamWriterPath.WriteLine("@echo.");
                        streamWriterPath.WriteLine("@echo [0;32m\"Search for a path.\"");
                        streamWriterPath.WriteLine("@echo. [0;37m");
                        streamWriterPath.WriteLine("cd %deployPath%");
                        streamWriterPath.WriteLine("%disk%");
                        streamWriterPath.WriteLine("@echo.");
                        streamWriterPath.WriteLine("@echo [0;32m\"Execute git command.\"");
                        streamWriterPath.WriteLine("@echo. [0;37m");
                        streamWriterPath.WriteLine("%gitPath% status");
                        streamWriterPath.WriteLine("%gitPath% add .");
                        streamWriterPath.WriteLine("%gitPath% commit -m %msg%");
                        streamWriterPath.WriteLine("%gitPath% push");
                        streamWriterPath.WriteLine("@echo.");
                        streamWriterPath.WriteLine("@echo [0;32m\"Conguatulations!The task has Completed!\"");
                        streamWriterPath.WriteLine("@echo. [0;37m");
                        streamWriterPath.WriteLine("pause");
                        streamWriterPath.Close();
                    }
                    Process proc = null;
                    try
                    {
                        string targetDir = string.Format(StartupPath);
                        proc = new Process();
                        proc.StartInfo.WorkingDirectory = targetDir;
                        proc.StartInfo.FileName = "git.bat";
                        string disk = deployTextBox.Text.Substring(0, 2);
                        proc.StartInfo.Arguments = string.Format(disk + " " + deployTextBox.Text + " \"" + messageTextBox.Text + "\" \"" + gitPathTextBox.Text + "\"");//this is argument
                        proc.Start();
                        proc.WaitForExit();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("执行完毕!");
                }
            }
        }
        /// <summary>
        /// 弹出文件夹选择器,获取路径
        /// </summary>
        /// <param name="tip">提示语</param>
        /// <returns>路径</returns>
        public String GetUserPath(string tip)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = tip;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.SelectedPath;
            }
            return "";
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            string tip = "请选择编译代码目录,即ng build产生的打包代码文件夹";
            distTextBox.Text = GetUserPath(tip);
            checkPath();
        }
        private void select2Button_Click(object sender, EventArgs e)
        {
            string tip = "请选择部署代码目录,即存放page的目录";
            deployTextBox.Text = GetUserPath(tip);
            checkPath();
        }
        /// <summary>
        /// 检查路径参数是否都已填写
        /// </summary>
        private void checkPath()
        {
            if (distTextBox.Text != "" && deployTextBox.Text != "" && gitPathTextBox.Text != "")
            {
                StartButton.Enabled = true;
            }
            else
            {
                StartButton.Enabled = false;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (noDeleteListView.SelectedItems.Count > 0)
            {
                noDeleteListView.Items.Remove(noDeleteListView.SelectedItems[0]);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            noDeleteListView.Items.Add(fileNameTextBox.Text);
            fileNameTextBox.Text = "";
        }

        private void StatementButton_Click(object sender, EventArgs e)
        {
            string tip;
            tip = "编译代码目录:\r\n" +
                "        指ng build之后,产生的打包代码文件.\r\n" +
                "\r\n" +
                "Page仓库目录:\r\n" +
                "        顾名思义,Page(部署)的仓库所在地.\r\n" +
                "\r\n" +
                "Git安装目录:\r\n" +
                "        使用cmd执行命令 where git 获取git的安装路径,一般默认是\r\n" +
                "        C:\\Program Files\\Git\\cmd\\git.exe\r\n" +
                "        你可以确认后将路径复制到此文本框.\r\n" +
                "\r\n" +
                "防删文件名单:\r\n" +
                "        点击开始后,程序会先将Page仓库内容清空,但是像.git README等文件是不应该删除的,可以将名字存入这个地方,防止文件被删除.\r\n" +
                "\r\n" +
                "使用Git上传:\r\n" +
                "        在完成文件的覆盖后,会自动执行Git命令上传至远程仓库,自动执行的命令包括 \"git add .\" \"git commit -m msg\" \"git push\",提交的msg来源于紧接其后的文本框内容.\r\n" +
                "\r\n" +
                "创建404文件:\r\n" +
                "        使用前端路由的项目,在刷新后会导致找不到文件此时需要一个404文件,勾选此项将自动添加至Page仓库.";
            MessageBox.Show(tip);
        }
        private void SaveSettingButton_Click(object sender, EventArgs e)
        {
            /*
             pathConfig.txt默认按以下顺序写数据
             dist
             deploy
             gitPath
             */
            //保存路径配置
            StreamWriter streamWriterPath = new StreamWriter(StartupPath + "\\pathConfig.txt", false);
            streamWriterPath.WriteLine(distTextBox.Text);
            streamWriterPath.WriteLine(deployTextBox.Text);
            streamWriterPath.WriteLine(gitPathTextBox.Text);
            streamWriterPath.Close();
            //保存防删文件配置
            StreamWriter streamWriterFile = new StreamWriter(StartupPath + "\\saveFilesConfig.txt", false);
            foreach(ListViewItem item in noDeleteListView.Items)
            {
                streamWriterFile.WriteLine(Convert.ToString(item.SubItems[0].Text));
            }
            streamWriterFile.Close();
            /*
             gitConfig.txt默认按以下顺序写数据
             message
             turn up
             404
             */
            //保存git commit message
            StreamWriter streamWriterGit = new StreamWriter(StartupPath + "\\gitConfig.txt", false);
            streamWriterGit.WriteLine(messageTextBox.Text);
            streamWriterGit.WriteLine(gitYesRadioButton.Checked.ToString());
            streamWriterGit.WriteLine(yes404RadioButton.Checked.ToString());
            streamWriterGit.Close();
            MessageBox.Show("保存成功!");
        }
        private void ReadingSetting()
        {
            //读取路径配置
            try
            {
                string pathValue;
                StreamReader streamWriterParh = File.OpenText(StartupPath + "\\pathConfig.txt");
                int index = 1;
                while ((pathValue = streamWriterParh.ReadLine()) != null)
                {
                    if (index == 1)
                    {
                        distTextBox.Text = pathValue;
                    }
                    else if (index == 2)
                    {
                        deployTextBox.Text = pathValue;
                    }
                    else if (index == 3)
                    {
                        gitPathTextBox.Text = pathValue;
                        break;
                    }
                    index++;
                }
                streamWriterParh.Close();
                checkPath();
            }
            catch (Exception)
            {

            }
            //读取防删文件配置
            string fileValue;
            try
            {
                StreamReader streamWriterFile = File.OpenText(StartupPath + "\\saveFilesConfig.txt");
                while ((fileValue = streamWriterFile.ReadLine()) != null)
                {
                    noDeleteListView.Items.Add(fileValue);
                }
                streamWriterFile.Close();
            }
            catch (Exception)
            {

            }
            //读取git commit message
            try
            {
                string msg;
                StreamReader streamWriterGit = File.OpenText(StartupPath + "\\gitConfig.txt");
                int index = 1;
                while ((msg = streamWriterGit.ReadLine()) != null)
                {
                    if (index == 1)
                    {
                        messageTextBox.Text = msg;
                    }
                    else if (index == 2)
                    {
                        if (Convert.ToBoolean(msg))
                        {
                            gitYesRadioButton.Checked = true;
                        }
                        else if(!Convert.ToBoolean(msg))
                        {
                            gitNoRadioButton.Checked = true;
                        }
                    }
                    else if (index == 3)
                    {
                        if (Convert.ToBoolean(msg))
                        {
                            yes404RadioButton.Checked = true;
                        }
                        else if (!Convert.ToBoolean(msg))
                        {
                            no404RadioButton.Checked = true;
                        }
                        break;
                    }
                    index++;
                }
                streamWriterGit.Close();
            }
            catch (Exception)
            {

            }
            checkPath();
        }
        //绑定回车事件
        private void fileNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                createButton_Click(sender,e);
            }
        }

        private void gitPathTextBox_TextChanged(object sender, EventArgs e)
        {
            checkPath();
        }
    }
}
