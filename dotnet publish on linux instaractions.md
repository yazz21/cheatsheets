mkdir /var/www/apps
sudo dotnet publish -c Release -o /var/ww/app
vim /etc/nginx/sites-available/default
        Content inside default.config file:
```groovy
    server {
        listen        80;
        server_name   example.com *.example.com;
        location / {
            proxy_pass         http://localhost:5000;
            proxy_http_version 1.1;
            proxy_set_header   Upgrade $http_upgrade;
            proxy_set_header   Connection keep-alive;
            proxy_set_header   Host $host;
            proxy_cache_bypass $http_upgrade;
            proxy_set_header   X-Forwarded-For $proxy_add_x_forwarded_for;
            proxy_set_header   X-Forwarded-Proto $scheme;
        }
    }
    
sudo nginx -t
sudo nginx -s reload 
sudo vim /etc/systemd/system/app.service
content inside app.service file:
    --------------
    [Unit] 
    Description= mvcnew webapp
    [Service] 
    WorkingDirectory=/var/www/app1
    ExecStart=/usr/bin/dotnet /var/www/app1/mvcnew.dll 
    Restart=always
    # Restart service after 10 seconds if the dotnet service crashes:
    RestartSec=10
    SyslogIdentifier=mvcnew
    Environment=ASPNETCORE_ENVIRONMENT=Production
    
    [Install]   
    WantedBy=multi-user.targe

sudo systemctl enable app.service
sudo systemctl start app.service
sudo systemctl status app.service