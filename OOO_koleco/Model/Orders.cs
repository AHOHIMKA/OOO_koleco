//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOO_koleco.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int OrdersID { get; set; }
        public int OrdersUserID { get; set; }
        public int OrdersCarsID { get; set; }
        public System.DateTime OrdersDate { get; set; }
    
        public virtual Cars Cars { get; set; }
        public virtual Users Users { get; set; }
    }
}
