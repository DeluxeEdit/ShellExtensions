try
{
 git -v
}
catch 
{ 
	winget install Git.Git
}
try
{
 dotnet   --version
}
catch 
{ 
 winget install Microsoft.DotNet.SDK.9
}
 

 git clone  https://github.com/DeluxeEdit/ShellExtensions.git
 dotnet build
 $destDir= "$env:USERPROFILE\DeluxeShellExtensaions"
$found =Test-Path $destDir
if ($found=false) 
{
	md $destDir
}
cd $destDir



