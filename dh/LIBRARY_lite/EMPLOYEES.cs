//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIBRARY_lite
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLOYEES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYEES()
        {
            this.USERS = new HashSet<USERS>();
        }
    
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeRole { get; set; }
        public bool IsWorking { get; set; }
    
        public virtual ROLES ROLES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERS> USERS { get; set; }
    }
}
