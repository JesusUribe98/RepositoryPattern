﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace RepositoryPattern.DAL.XPO.RepositoryPattern
{

    public partial class UserXPO : XPObject
    {
        string fUserName;
        [Size(50)]
        public string UserName
        {
            get { return fUserName; }
            set { SetPropertyValue<string>(nameof(UserName), ref fUserName, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
    }

}