
using MiNET.Plugins;
using MiNET.Plugins.Attributes;

/*
    ########  #### ########    ###    
    ##     ##  ##  ##         ## ##   
    ##     ##  ##  ##        ##   ##  
    ########   ##  ######   ##     ## 
    ##         ##  ##       ######### 
    ##         ##  ##       ##     ## 
    ##        #### ######## ##     ## 
    
    PIEA, MINET Developers' Organization.
*/

namespace Template
{

    [Plugin(PluginName = "Template", Description = "PIEA plugin basic template.", PluginVersion = "None", Author = "PIEA")]
    public class Template : Plugin
    {

        protected override void OnEnable()
        {
           
        }

        public override void OnDisable()
        {
            
        }
    }
}
