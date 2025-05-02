#    disable SELINUX
    run     
    ```sestatus```
    set SELINUX=PERMISSIVE  IN /etc/sysconfig/selinux

    then 
        ** ln -s gitolite3/ gitolite
        ** chown -R gitolite:gitolite gitolite
        ** chown -R gitolite:gitolite gitolite3
        ** chmod o-rx gitolite
        ** chmod o-rx gitolite3
        ** ls -lah /var/lib/