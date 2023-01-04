onfigure GitLab for your system by editing /etc/gitlab/gitlab.rb file
 And restart this container to reload settings.
 To do it use docker exec:
 
   docker exec -it gitlab editor /etc/gitlab/gitlab.rb
   docker restart gitlab
 
 For a comprehensive list of configuration options please see the Omnibus GitLab readme
 https://gitlab.com/gitlab-org/omnibus-gitlab/blob/master/README.md
 
 If this container fails to start due to permission problems try to fix it by executing:
 
   docker exec -it gitlab update-permissions
   docker restart gitlab
