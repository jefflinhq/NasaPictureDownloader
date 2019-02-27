## **Description**

This repository contains four projects.

1. NasaApi – it is a class library that wraps NASA API described [here](https://api.nasa.gov/api.html).
2. DownloadNasaApodFiles – this is a .net console application that makes sure of the NasaApi library to download NASA pictures to local folder. The dates.txt file includes the dates of the pictures you want to download.
3. ShowNasaPictures – this is a .net core Agular project that shows the NASA pages. The dates.txt file includes the dates of the pictures you want to download.
4. NasaApiTest – a Nunit test project that tests the NasaApi class.

## **How to build DownloadNasaApodFiles**

- You need to Visual Studio 2017 with .net core 2.0.
- Open solution file NasaApi.sln in Visual Studio.
- Restore Nuget Packages. To do so, right click on the solution in the Solution Explorer view. Then click &quot;Restore Nuget Packages&quot;.
- Now you can build the solution.

## **How to run DownloadNasaApodFiles**

- After build, the execution file, dll, can be found in bin\Debug\netcoreapp2.1 or bin\Release\netcoreapp2.1 folder depending on the build configuration you chose.
- Create a text file named dates.txt in the same folder of the dll file. Include the dates of the pictures you want to download. A sample file is provided in DownloadNasaApodFiles folder.
- Open Command Prompt and change the directiory to the dll file.
- Run the following command &quot;dotnet downloadnasaapodfiles.dll&quot;
- The pictures will be downloaded to the same folder.

## **How to build and run ShowNasaPictures**

- Build the project in Visual Studio 2017.
- You can either run it from Visual Studio 2017 or run &quot;dotnet run&quot; in command prompt