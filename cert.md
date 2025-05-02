# 1. Generate RSA
bash
openssl genrsa -aes256 -out ca-key.pem 4096
# 2. Generate a public CA Cert
bash
openssl req -new -x509 -sha256 -days 365 -key ca-key.pem -out ca.pem
# 3. To view public CA cert
bash
openssl x509 -in ca.pem -text

# Generate Certificate
1. Create a RSA key
bash
openssl genrsa -out cert-key.pem 4096
2. Create a Certificate Signing Request (CSR)
bash
openssl req -new -sha256 -subj "/CN=yourcn" -key cert-key.pem -out cert.csr
3. Create a extfile with all the alternative names
bash
echo "subjectAltName=DNS:your-dns.record,IP:257.10.10.1" >> extfile.cnf
bash
# optional
echo extendedKeyUsage = serverAuth >> extfile.cnf
4. Create the certificate
bash
openssl x509 -req -sha256 -days 365 -in cert.csr -CA ca.pem -CAkey ca-key.pem -out cert.pem -extfile extfile.cnf -CAcreateserial

# Install the CA Cert as a trusted root CA

## On Windows

Assuming the path to your generated CA certificate as C:\ca.pem, run:
    powershell
    Import-Certificate -FilePath "C:\ca.pem" -CertStoreLocation Cert:\LocalMachine\Root
    
    - Set -CertStoreLocation to Cert:\CurrentUser\Root in case you want to trust certificates only for the logged in user.

    OR

    In Command Prompt, run:
    sh
    certutil.exe -addstore root C:\ca.pem
    

    - certutil.exe is a built-in tool (classic System32 one) and adds a system-wide trust anchor.


## on jenkins
    keytool -import -keystore /opt/java/jdk.1.0.9/lib/security/cacerts -file CA.crt -alias [domain name]

    cp CA.crt /usr/local/share//usr/local/share/ca-certificates/ca.crt
                /etc/pki/ca-trust/source/anchors/ca.pem` or /usr/share/pki/ca-trust-source/anchors/ca.pem

    sudo update-ca-certificates

    restart service/pc
## on tuleap
    find the cert file and replace the content with the new generated cert
