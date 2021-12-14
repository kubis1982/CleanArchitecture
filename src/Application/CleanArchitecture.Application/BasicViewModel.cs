namespace CleanArchitecture.Application {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class BasicViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool SetValue<T>(ref T field, T value, [CallerMemberName] string propertyName = null) {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            else {
                field = value;

                this.OnPropertyChanged(propertyName);

                return true;
            }
        }

    }
}
