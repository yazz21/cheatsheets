# Configuration
## Discard old builds
    check the checkbox ✔️
## Do not allow concurrent builds
    check the checkbox ✔️
## Do not allow the pipeline to resume if the controller restarts
    check the checkbox ✔️
# Build Triggers
## Generic Webhook Trigger
    check the checkbox ✔️
     + get the CI Token from the project setting and insert it into Token text box
# Pipeline
## select Pipeline Script from dropdown
### 
```groovy
pipeline {
    agent any

    stages {
        stage("clone") {
            steps {
                echo 'Hello World'
```
### Edit
````groovy
                checkout([$class: 'GitSCM', branches: [[name: '*/master']], extensions: [], userRemoteConfigs: [[credentialsId: 'devop', url: 'https://ALM.xokait.com.et/plugins/git/hydrological/Map.git']]])
````
                powershell 'pwd'
                powershell 'npm i'
                powershell 'ng build --prod --output-hashing none'
                powershell 'ls'
                
````groovy
                powershell 'Compress-Archive -Path C:/ProgramData/Jenkins/.jenkins/workspace/Oro_Map/dist/Map/*.* -CompressionLevel Fastest -DestinationPath C:/ProgramData/Jenkins/.jenkins/workspace/Oro_Map/dist/Map/map.zip -Force'
````
````groovy
                powershell '[string][ValidateNotNullOrEmpty()] $userPassword = "P@ssw0rdx12345"; $password = ConvertTo-SecureString -String $userPassword -AsPlainText -Force; $userCredential = New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "Administrator", $password; Invoke-Command -VMName XOKA_DEV_Server -ScriptBlock {Powershell.exe "F:/jenkinshub/OroMap/del.ps1" } -Credential $userCredential; '
````
````groovy
                powershell 'Copy-VMFile "XOKA_DEV_Server" -SourcePath "C:/ProgramData/Jenkins/.jenkins/workspace/Oro_Map/dist/Map/map.zip" -DestinationPath "F:/Solution/inetpub/OROMDA/XOKASWCMS2/DesktopModules/MVC/MapLicencedSite/Views/Item/assets/map.zip" -Force -CreateFullPath -FileSource Host '
```
````grovvy
                powershell '[string][ValidateNotNullOrEmpty()] $userPassword = "P@ssw0rdx12345"; $password = ConvertTo-SecureString -String $userPassword -AsPlainText -Force; $userCredential = New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "Administrator", $password; Invoke-Command -VMName XOKA_DEV_Server -ScriptBlock {powershell.exe Expand-Archive -LiteralPath F:/Solution/inetpub/OROMDA/XOKASWCMS2/DesktopModules/MVC/MapLicencedSite/Views/Item/assets/map.zip -DestinationPath F:/Solution/inetpub/OROMDA/XOKASWCMS2/DesktopModules/MVC/MapLicencedSite/Views/Item/assets/ -Force } -Credential $userCredential; '
            }
        }
        // stage ("build") {
        //   step {
               
        //   }
        // }
    }
}
````