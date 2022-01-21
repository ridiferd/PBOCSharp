using System.Data.SQLite;

// change this URI with absolute path of the file
// clear the DB : delete and create again
string data = @"URI=file:{{ABSOLUTE PATH}}}}\Data\Test.db";

/// CREATE TABLE AND INSERT DATA ///
using var con = new SQLiteConnection(data);
con.Open();

using var cmd = new SQLiteCommand(con);
cmd.CommandText = "DROP TABLE IF EXISTS  cars";
cmd.ExecuteNonQuery();

cmd.CommandText = @"CREATE TABLE cars(id INTEGER PRIMARY KEY,
            name TEXT, price INT)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mazda',450000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mascheratti',400000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Citroen',390000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Jaguar',410000)";
cmd.ExecuteNonQuery();
con.Close();

Console.WriteLine("Table created and data inserted");

// USING SQLITE PREPARED STATEMENTS
// using var con = new SQLiteConnection(data);
// con.Open();

// using var cmd = new SQLiteCommand(con);
// cmd.CommandText = "INSERT INTO cars(name, price) VALUES(@name, @price)";

// cmd.Parameters.AddWithValue("@name", "ESEMKA");
// cmd.Parameters.AddWithValue("@price", 500000);
// cmd.Prepare();
// cmd.ExecuteNonQuery();

// Console.WriteLine("row inserted");
// con.Close();

// GET DATA FROM DB
//
// using var con = new SQLiteConnection(data);
// con.Open();

// string query  = "SELECT * FROM cars";
// using var cmdq = new SQLiteCommand(query, con);
// using SQLiteDataReader rdr = cmdq.ExecuteReader();

// while(rdr.Read())
// {
//     Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetInt32(2)}");
// }
// con.Close();