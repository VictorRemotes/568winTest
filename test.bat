@echo off
echo Press any key to start
pause
echo Executing...
Java -cp bin;lib/* org.testng.TestNG testng.xml
echo Press any key to end
pause
exit