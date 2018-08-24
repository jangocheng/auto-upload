# auto-upload
在实际开发过程中存在以下场景
 - 写完代码后打包,需要手动将编译后的代码复制到部署的文件夹
 - 如果部署的是page服务,需要先将原先的一些过时文件删除(之前版本的JS),但是又不能全删,需要保留一些文件(.git README.md) 
 - page的仓库每次都要运行 `git add .`、`git commit -m msg`、`git push`,太麻烦了 

针对这个问题,这个小工具可以帮助开发者们自动完成这些繁琐的操作.
# 介绍
![1](https://github.com/Eve-1995/auto-upload/blob/master/img/form-container.png)

具体用法演示及源码分析视频请访问 [angular.ink/recommend/auto-upload](angular.ink/recommend/auto-upload) 进行查看.