@echo.
@echo [0;32m"Start accept arguments."
@echo. [0;37m
set disk=%1%
set deployPath=%2%
set msg=%3%
set gitPath=%4%
@echo.
@echo [0;32m"Search for a path."
@echo. [0;37m
cd %deployPath%
%disk%
@echo.
@echo [0;32m"Execute git command."
@echo. [0;37m
%gitPath% status
%gitPath% add .
%gitPath% commit -m %msg%
%gitPath% push
@echo.
@echo [0;32m"Conguatulations!The task Completed!"
@echo. [0;37m
pause
