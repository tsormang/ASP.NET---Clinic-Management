
web.configfile ==========================================>

<connectionString>
  <add name="ClinicDB" connectionString="data source={{yourSQL}}; 
    initial catalog={{yourName}};
      Integrated Security=True" 
        providerName="System.Data.SqlClient" />
</connectionString>


Package manager console ==================================>

- enable-migrations
- add-migration "InitialCreate"
- update-database

Open the database at table: AspNetRoles ==================>

add Administrator. 
add Doctor.

Run the project  =========================================> 

http://localhost:xxxx/Account/Register 
(you can now add an admin user)
