# login
    sudo -u postgres psql

# Create the user
    CREATE USER postgres WITH PASSWORD 'postgres';

# Grant necessary privileges to the user
    GRANT ALL PRIVILEGES ON DATABASE starter TO postgres;
