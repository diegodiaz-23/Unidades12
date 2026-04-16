/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package javaapplication1;
import java.sql.*;

public class Conexion {
public static Connection getConexion() {
        Connection con = null;
        
        try {
            String url = "jdbc:mysql://localhost:3306/colegio";
            String user = "root";
            String password = "vistahermosa";
            
            con = DriverManager.getConnection(url, user, password);
            
        } catch (Exception e) {
            System.out.println("Error de conexión: " + e);
        }
        
        return con;
    }
}
    

