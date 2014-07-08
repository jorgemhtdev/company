﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioGestion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioGestion" in both code and config file together.
    [ServiceContract]
    public interface IServicioGestion
    {
        //EMAIL
       
        //Método que añade un email
        [OperationContract]
        bool addEmail(string correo);

        //Método que obtiene todos los emails
        [OperationContract]
        List<EmailData> getAllEmail();

        //Método que obtiene un email con un identificador concreto
        [OperationContract]
        EmailData getEmailId(int id);

        //Método que obtiene un email con un correo concreto
        [OperationContract]
        EmailData getEmailCorreo(string correo);

        //Método que elimina de la tabla Email un registro
        [OperationContract]
        bool deleteEmail(int idEmail);

        //Método que edita un registro de la tabla Email 
        [OperationContract]
        bool editEmail(int idEmail, string correo);

        //FIN EMAIL

        /// Direccion
       
        [OperationContract]
        bool AddDireccion(DireccionData street);
        [OperationContract]
        bool DeleteDireccion(DireccionData street, int id);
        [OperationContract]
        bool EditDireccion(DireccionData street, int id);
        [OperationContract]
        List<DireccionData> GetDireccion();

        /// Fin Direccion

        /// Sector
        
        [OperationContract]
        List<SectorData> GetSector();

        /// Fin sector
        
        /// Estado de accion
        
        [OperationContract]
        List<EstadoAccion> GetEstadoAccion();

        /// Fin estado de accion

        
        // Usuario
        [OperationContract]
        bool addUsuario(UsuarioData usuario);

        [OperationContract]
        bool deleteUsuario(int idUsuario);

        [OperationContract]
        bool editUsuario(int idUsuario, UsuarioData user);

        [OperationContract]
        List<UsuarioData> getAllUsuarios();

        [OperationContract]
        UsuarioData getUsuario(int idUsuario);
        //Fin Usuario

        /// Contacto

        [OperationContract]
        List<ContactoData> GetContacto();

        [OperationContract]
        bool DeleteContacto(ContactoData contacto, int id);

        [OperationContract]
        bool AddContacto(ContactoData contacto);

        [OperationContract]
        bool EditContacto(ContactoData contacto, int id);

        /// Fin contacto    
    }

    
    //EMAIL

    [DataContract]
    public class EmailData
    {
        [DataMember]
        public int EmailID;
        [DataMember]
        public string Correo;

    }

    //FIN EMAIL

    /// Direccion
 
    [DataContract]
    public class DireccionData
    {
        [DataMember]
        public int idDireccion;
        [DataMember]
        public string domicilio;
        [DataMember]
        public string poblacion;
        [DataMember]
        public string codPostal;
        [DataMember]
        public string provincia;
    }
        
    //fin Direccion

    /// Sector

    [DataContract]
    public class SectorData
    {
        [DataMember]
        public int idSector;
        [DataMember]
        public string descripcion;

    }

    //fin Sector


    /// Estado de accion

    [DataContract]
    public class EstadoAccion
    {
        [DataMember]
        public int idEstadoAccion;
        [DataMember]
        public string descripcion;
    }

    //fin estado de accion

    //Usuario
    [DataContract]
    public class UsuarioData
    {
        [DataMember]
        public int idUsuario;

        [DataMember]
        public string login;

        [DataMember]
        public string nombre;

        [DataMember]
        public string password;
    }
    //Fin Usuario

    /// Contacto
    [DataContract]
    public class ContactoData
    {
        [DataMember]
        public int idContacto;
        [DataMember]
        public string nif;
        [DataMember]
        public string nombre;
        [DataMember]
        public int idEmpresa;
    }
    /// Fin contacto


}
