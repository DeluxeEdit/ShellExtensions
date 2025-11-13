 $found =Test-Path "$env:USERPROFILE\ShellAnything"
if ($found=false) 
{
	md "$env:USERPROFILE\ShellAnything"
}
cd "$env:USERPROFILE\ShellAnything"
regsvr32 sadeluxeeditextension.dll


