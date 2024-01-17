@echo off

set /p fileName=Enter the file name : 

set "currentDir=%cd%"

set "currentDir=%currentDir:\=\\%"

echo data = {} > "%cd%\%fileName%"
echo dofile("%currentDir%\\PrintData") >> "%cd%\%fileName%"
echo PrintData(data) >> "%cd%\%fileName%"