# Serilog with Seq Dashboard
To see log into Seq Dashboard as like 

![seq](https://github.com/Md-Atiqur-Rahman/SerilogwithSeq/assets/37808900/5a0b4742-b294-4af9-bac9-52ccd3f80355)

- Need to configure
- Create a web Api
- Install this Package
  1. Install-Package  Serilog.AspNetCore
  2. Install-Package  Serilog.Settings.Configuration
  3. Install-Package  Serilog.Enrichers.Environment
  4. Install-Package  Serilog.Enrichers.Thread
  5. Install-Package  Serilog.Enrichers.Process
  6. Install-Package Serilog.Formatting.Compact
- Need configuration in your appsettings like
  ![appsettings](https://github.com/Md-Atiqur-Rahman/SerilogwithSeq/assets/37808900/f75834fe-136e-4b99-8648-a08447e29359)

- Go to Program file
  
![program](https://github.com/Md-Atiqur-Rahman/SerilogwithSeq/assets/37808900/8511bb44-39d0-4d04-96ec-bb8f50697a43)

- In Your method create log
  ![method](https://github.com/Md-Atiqur-Rahman/SerilogwithSeq/assets/37808900/b7406f74-25ec-4b26-b354-1bc3152eaead)

- the log file will be create when run the app and click this method.
  
![swagger](https://github.com/Md-Atiqur-Rahman/SerilogwithSeq/assets/37808900/4cc2a179-bae6-41e0-abf9-8a9ad29c8df3)

- and log.txt file
  ![txt](https://github.com/Md-Atiqur-Rahman/SerilogwithSeq/assets/37808900/9a8d9f1f-0065-4e82-b32e-b2623050d995)

- Now we have to Use Seq dashboard. For this we need to Docker
  1. Install Docker Desktop on Windows
  2. Run Docker App
  3. To check docker image - docker images
- Create docker seq images
   - docker run -d --restart unless-stopped --name seq -e ACCEPT_EULA=Y -v D:\RND\Test\SeqLog\logs:/data -p 8081:80 datalust/seq:latest
 
![docker command](https://github.com/Md-Atiqur-Rahman/SerilogwithSeq/assets/37808900/51134053-0b06-48db-80da-52b2a68173ba)

- After created docker container  you can see in your vs code
   ![docker image](https://github.com/Md-Atiqur-Rahman/SerilogwithSeq/assets/37808900/c8e06663-f6cf-4b7c-b64d-564afd39aa86)
- And also see in your folder some file is uploaded
 ![seq location](https://github.com/Md-Atiqur-Rahman/SerilogwithSeq/assets/37808900/004e109c-3fd9-499d-a1ed-0f82b3050c0d)

- now run your app agin and another tab use localhost:8081 ,you can see seq dashboard
  
![seq](https://github.com/Md-Atiqur-Rahman/SerilogwithSeq/assets/37808900/a9a54d2d-17c5-4fbf-b9d5-359d2a8c61fe)

