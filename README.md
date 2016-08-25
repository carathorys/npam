# Npam
Npam is a dotnet core interface and wrapper around the UNIX Pluggable Authentication Modules (PAM) libraries. Npam also includes dotnet core interfaces into other related library calls for group and account information.

##### Table of Contents  
1. [Compatibility](#Compatibility)  
2. [Using the Npam Library](#Using_the_Npam_Library)
  * [Npam prerequisits](#Npam_prerequisits)
  * [Getting the Npam Library](#Getting_the_Npam_Library)
  * [Calling into the Npam Library](#Calling_into_the_Npam_Library)
    * [NpamUser](#NpamUser)
    * [NpamSession](#NpamSession)
3. [Using the Npam source](#Using_the_Npam_source)
  * [On Ubuntu](#On_Ubuntu)
  * [On Fedora](#On_Fedora)
  * [On Other Systems](#On_Other_Systems)

<a name="Compatibility"/>
##Compatibility
Npam has been tested on Ubuntu 16.04 (dotnet version 1.0.0-preview2-003121) and Fedora 23 (dotnet version 1.0.0-preview2-003121). However, PAM is available on most *nix systems and this library should work on Mac, BSD and most linux distros. So feel free to give it a try and create a PR or issue if you run into any problems.

<a name="Using_the_Npam_Library"/>
##Using the Npam Library

<a name="Npam_prerequisits"/>
###Npam prerequisits
Before using the library, you will also need to ensure that the PAM development libraries are installed for your distro.
For Ubuntu:`sudo apt-get install libpam0g-dev` and for Fedora: `sudo dnf -y install pam-devel`

<a name="Getting_the_Npam_Library"/>
###Getting the Npam Library
The best way to make use of the Npam library is to include it as a nuget dependency. Npam is available on nuget at https://www.nuget.org/packages/Npam

As below, you'll need to add a Npam dependency to your app's project.json and run dotnet restore to get the library.
```
{
  "name" : "Npam-sample",
  ...
  "dependencies": { "Npam" : "1.0.0" },
  ...
}
```

<a name="Calling_into_the_Npam_Library"/>
###Calling into the Npam Library
There are 2 interfaces into PAM through this library. NpamUser and NpamSession.

<a name="NpamUser"/>
####NpamUser
A static class with 3 public methods to call into PAM and related interfaces for group and account information. Useful when the calling application just needs to authenticate users and retrieve assoicated information and does not require more complex interaction with PAM. Only allows for interaction with PAM modules which require a single password response when to PAM conversation messages.

For an example app using NpamUser, have a look here: https://github.com/CamW/npam/blob/master/src/Npam.Example.User/Program.cs

<a name="NpamSession"/>
####NpamSession
A session class which allows the calling application to establish a PAM session and interact with the session. Only destroying the underlying session on disposal of the NpamSession. NpamSession is more powerful than PamUser, allowing for custom PAM conversation handling and by extension, interaction with PAM modules which require more than just a password for authentication.

For an example app using NpamSession, have a look here: https://github.com/CamW/npam/blob/master/src/Npam.Example.Session/Program.cs

<a name="Using_the_Npam_source"/>
##Using the Npam source

Below are the commands you would use to get, restore, build and run the Npam library, tests and example applications.

<a name="On_Ubuntu"/>
### On Ubuntu

Install pam-devel: 
```
sudo apt-get install libpam0g-dev
```
From your home dir, clone repo: 
```
git clone https://github.com/camw/npam
```
Run the setup test account script to create a test user. This creates a user with username userxyz and a password of pwd123 which is used in the Npam test suite and can be used with the two example applications too: 
```
~/npam/test/setup_test_account.sh
```
Restore, build and run the Example.User app:
```
cd ~/npam/src/Npam.Example.User/
dotnet restore
sudo dotnet run
```
Restore, build and run the Example.Session app:
```
cd ~/npam/src/Npam.Example.Session/
dotnet restore
sudo dotnet run
```
Restore, build and run the Npam test suite:
```
cd ~/npam/test/Npam.Tests/
dotnet restore
sudo dotnet test
```
    
<a name="On_Fedora"/>
### On Fedora
Install pam-devel: 
```
sudo dnf -y install pam-devel
```
From your home dir, clone repo: 
```
git clone https://github.com/camw/npam
```
Run the setup test account script to create a test user. This creates a user with username userxyz and a password of pwd123 which is used in the Npam test suite and can be used with the two example applications too: 
```
~/npam/test/setup_test_account.sh
```
Restore, build and run the Example.User app:
```
cd ~/npam/src/Npam.Example.User/
dotnet restore
sudo /opt/dotnet/dotnet run
```
Restore, build and run the Example.Session app:
```
cd ~/npam/src/Npam.Example.Session/
dotnet restore
sudo /opt/dotnet/dotnet run
```
Npam test suite has known issues on Fedora 23. Doing a dotnet restore on the project results in the following error:
```
log  : Restoring packages for /root/npam/test/Npam.Tests/project.json...
log  : Failed to download package from 'https://api.nuget.org/v3-flatcontainer/system.runtime.handles/4.0.1-rc2-24027/system.runtime.handles.4.0.1-rc2-24027.nupkg'.
log  : Response status code does not indicate success: 404 (Not Found).
```

<a name="On_Other_Systems"/>
### On Other Systems
PAM is available on most *nix systems and this library should work on Mac, BSD and most linux distros. So feel free to give it a try and create a PR or issue.
