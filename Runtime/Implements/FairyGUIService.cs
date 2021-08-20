using System.Collections.Generic;
using System.Threading.Tasks;
using HoweFramework.UI.Interfaces;

namespace HoweFramework.FairyGUI
{
    public class FairyGUIService : IUIService
    {
        private readonly Dictionary<string, BaseUIWindow> _uiWindows = new Dictionary<string, BaseUIWindow>();
        
        public Task OpenUIAsync(string uiKey, object userData = null)
        {
            if (_uiWindows.TryGetValue(uiKey, out var window))
            {
                window.UpdateUserData(userData);
                return Task.CompletedTask;
            }
            
            return Task.CompletedTask;
        }

        public void OpenUI(string uiKey, object userData = null)
        {
            throw new System.NotImplementedException();
        }

        public void CloseUI(string uiKey)
        {
            throw new System.NotImplementedException();
        }

        public bool HasUI(string uiKey)
        {
            throw new System.NotImplementedException();
        }
    }
}