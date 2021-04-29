using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public enum EntityStateOptions
    {
        Active,
        Deleted
    }

    /// <summary>
    /// Base class for all entity. Contains IsNew, HasChanged, Validate and EntityState
    /// </summary>
    public abstract class EntityBase
    {
        // checks if an entity is active or deleted
        public EntityStateOptions EntityState{ get; set; }

        //checks if a data is new or not
        public bool IsNew { get; set; }

        //checks if a data has changed or not
        public bool  HasChanged { get; set; }

        
        
       
    }
}
