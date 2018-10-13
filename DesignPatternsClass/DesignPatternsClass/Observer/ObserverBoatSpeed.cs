using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ObserverBoatSpeed
    {
        //delegate
        public event EventHandler ValueChanged;
        private int _currentSpeed;

        public ObserverBoatSpeed()
        {
            _currentSpeed = 0;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                this._currentSpeed = value;
                OnValueChanged();
            }

            get
            {
                return _currentSpeed;
            }
        }

        //method associated with above delegate
        protected void OnValueChanged()
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, EventArgs.Empty);
            }
        }
    }
}
