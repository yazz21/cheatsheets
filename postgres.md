# login
    sudo -u postgres psql

# Create the user
    CREATE USER postgres WITH PASSWORD 'postgres';

# Grant necessary privileges to the user
    GRANT ALL PRIVILEGES ON DATABASE starter TO postgres;

# Backup database
pg_dump "postgresql://<username>:<password>@example.us-east-1.postgres.vercel-storage.com:5432/verceldb" -F c -b -v -f <backup_file_name>.dump

# Restore Database
pg_restore -d "postgresql://<username>:<password>@example.us-east-1.postgres.vercel-storage.com:5432/verceldb" <backup_file_name>.dump

