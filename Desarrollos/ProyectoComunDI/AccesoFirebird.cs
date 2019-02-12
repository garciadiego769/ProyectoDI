using System;

public class AccesoFirebird
{
	public AccesoFirebird()
	{
        FbConnectionStringBuilder cs = new FbConnectionStringBuilder();

        //cs.DataSource = "localhost";
        cs.Database = "c:\\Users\\isabe\\Desktop\\PROYECTO DI\\IRIS.fdb";
        cs.UserID = "SYSDBA";
        cs.Password = "izaisa";
        cs.Charset = "NONE";
        cs.Pooling = false;
        cs.ServerType = FbServerType.Default;


        FbConnection connection = new FbConnection(cs.ToString());

        connection.Open();

        // Get the available metadata Collection names
        DataTable metadataCollections = connection.GetSchema();

        // Get datatype information
        DataTable dataTypes = connection.GetSchema(DbMetaDataCollectionNames.DataTypes);

        // Get DataSource Information
        DataTable dataSourceInformation = connection.GetSchema(DbMetaDataCollectionNames.DataSourceInformation);

        // Get available reserved word
        DataTable reservedWords = connection.GetSchema(DbMetaDataCollectionNames.ReservedWords);

        // Get the list of User Tables
        // Restrictions:
        // TABLE_CATALOG
        // TABLE_SCHEMA
        // TABLE_NAME
        // TABLE_TYPE
        DataTable userTables = connection.GetSchema("Tables", new string[] { null, null, null, "TABLE" });

        // Get the list of System Tables
        // Restrictions:
        // TABLE_CATALOG
        // TABLE_SCHEMA
        // TABLE_NAME
        // TABLE_TYPE
        DataTable systemTables = connection.GetSchema("Tables", new string[] { null, null, null, "SYSTEM TABLE" });

        // Get Table Columns
        // Restrictions:
        // TABLE_CATALOG
        // TABLE_SCHEMA
        // TABLE_NAME
        // COLUMN_NAME
        DataTable tableColumns = connection.GetSchema("Columns", new string[] { null, null, "TableName" });

        connection.Close();
    }
}
