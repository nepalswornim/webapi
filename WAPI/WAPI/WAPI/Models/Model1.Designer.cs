﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace WAPI.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class WAPI_DBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new WAPI_DBEntities object using the connection string found in the 'WAPI_DBEntities' section of the application configuration file.
        /// </summary>
        public WAPI_DBEntities() : base("name=WAPI_DBEntities", "WAPI_DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WAPI_DBEntities object.
        /// </summary>
        public WAPI_DBEntities(string connectionString) : base(connectionString, "WAPI_DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WAPI_DBEntities object.
        /// </summary>
        public WAPI_DBEntities(EntityConnection connection) : base(connection, "WAPI_DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<wa_App_User> wa_App_User
        {
            get
            {
                if ((_wa_App_User == null))
                {
                    _wa_App_User = base.CreateObjectSet<wa_App_User>("wa_App_User");
                }
                return _wa_App_User;
            }
        }
        private ObjectSet<wa_App_User> _wa_App_User;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the wa_App_User EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTowa_App_User(wa_App_User wa_App_User)
        {
            base.AddObject("wa_App_User", wa_App_User);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WAPI_DBModel", Name="wa_App_User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class wa_App_User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new wa_App_User object.
        /// </summary>
        /// <param name="userID">Initial value of the UserID property.</param>
        public static wa_App_User Createwa_App_User(global::System.Int32 userID)
        {
            wa_App_User wa_App_User = new wa_App_User();
            wa_App_User.UserID = userID;
            return wa_App_User;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                if (_UserID != value)
                {
                    OnUserIDChanging(value);
                    ReportPropertyChanging("UserID");
                    _UserID = StructuralObject.SetValidValue(value, "UserID");
                    ReportPropertyChanged("UserID");
                    OnUserIDChanged();
                }
            }
        }
        private global::System.Int32 _UserID;
        partial void OnUserIDChanging(global::System.Int32 value);
        partial void OnUserIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Username
        {
            get
            {
                return _Username;
            }
            set
            {
                OnUsernameChanging(value);
                ReportPropertyChanging("Username");
                _Username = StructuralObject.SetValidValue(value, true, "Username");
                ReportPropertyChanged("Username");
                OnUsernameChanged();
            }
        }
        private global::System.String _Username;
        partial void OnUsernameChanging(global::System.String value);
        partial void OnUsernameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, true, "Password");
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                OnFullNameChanging(value);
                ReportPropertyChanging("FullName");
                _FullName = StructuralObject.SetValidValue(value, true, "FullName");
                ReportPropertyChanged("FullName");
                OnFullNameChanged();
            }
        }
        private global::System.String _FullName;
        partial void OnFullNameChanging(global::System.String value);
        partial void OnFullNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true, "Email");
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Contact
        {
            get
            {
                return _Contact;
            }
            set
            {
                OnContactChanging(value);
                ReportPropertyChanging("Contact");
                _Contact = StructuralObject.SetValidValue(value, true, "Contact");
                ReportPropertyChanged("Contact");
                OnContactChanged();
            }
        }
        private global::System.String _Contact;
        partial void OnContactChanging(global::System.String value);
        partial void OnContactChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                OnIsActiveChanging(value);
                ReportPropertyChanging("IsActive");
                _IsActive = StructuralObject.SetValidValue(value, "IsActive");
                ReportPropertyChanged("IsActive");
                OnIsActiveChanged();
            }
        }
        private Nullable<global::System.Boolean> _IsActive;
        partial void OnIsActiveChanging(Nullable<global::System.Boolean> value);
        partial void OnIsActiveChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> IsDeleted
        {
            get
            {
                return _IsDeleted;
            }
            set
            {
                OnIsDeletedChanging(value);
                ReportPropertyChanging("IsDeleted");
                _IsDeleted = StructuralObject.SetValidValue(value, "IsDeleted");
                ReportPropertyChanged("IsDeleted");
                OnIsDeletedChanged();
            }
        }
        private Nullable<global::System.Boolean> _IsDeleted;
        partial void OnIsDeletedChanging(Nullable<global::System.Boolean> value);
        partial void OnIsDeletedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> AddedOn
        {
            get
            {
                return _AddedOn;
            }
            set
            {
                OnAddedOnChanging(value);
                ReportPropertyChanging("AddedOn");
                _AddedOn = StructuralObject.SetValidValue(value, "AddedOn");
                ReportPropertyChanged("AddedOn");
                OnAddedOnChanged();
            }
        }
        private Nullable<global::System.DateTime> _AddedOn;
        partial void OnAddedOnChanging(Nullable<global::System.DateTime> value);
        partial void OnAddedOnChanged();

        #endregion

    }

    #endregion

}
