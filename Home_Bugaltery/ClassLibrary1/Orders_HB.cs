
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ClassLibrary1
{

using System;
    using System.Collections.Generic;
    
public partial class Orders_HB
{

    public int Id { get; set; }

    public int Category_Id { get; set; }

    public int User_Id { get; set; }

    public decimal Price { get; set; }

    public System.DateTime Date { get; set; }

    public string Description { get; set; }



    public virtual Categories_HB Categories_HB { get; set; }

    public virtual Users_HB Users_HB { get; set; }

}

}