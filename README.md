## **Description**

This repository contains all the code related to the .net application NasaPictureDownloader. It downloads pictures from NASA web site using NASA API described [here](https://api.nasa.gov/api.html).

## **How to build**

- You need to Visual Studio 2017 with .net core 2.0.
- Open solution file NasaApi.sln in Visual Studio.
- Restore Nuget Packages. To do so, right click on the solution in the Solution Explorer view. Then click &quot;Restore Nuget Packages&quot;.
- Now you can build the solution.

## **How to run**

- After build, the execution file, dll, can be found in bin\Debug\netcoreapp2.1 or bin\Release\netcoreapp2.1 folder depending on the build configuration you chose.
- Create a text file named txt in the same folder of the dll file. Include the dates of the pictures you want to download. A sample file is provided in DownloadNasaApodFiles folder.
- Open Command Prompt and change the directiory to the dll file.
- Run the following command &quot;dotnet downloadnasaapodfiles.dll&quot;
- The pictures will be downloaded to the same folder.
