using System;
using System.Reflection;
using System.Windows.Forms;

namespace Teretan
{
    class DataControl
    {
        const int TYPE_STRING = 0;
        const int TYPE_INT = 1;
        const int TYPE_BOOL = 2;
        const int TYPE_DATE = 3;
        const int TYPE_DOUBLE = 4;

        public Control Source;
        public PropertyInfo Property;
        public int Type;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataControl"/> class.
        /// </summary>
        /// <param name="Source">Control associated with user's property</param>
        /// <param name="Property">User's property associated with the control</param>
        /// <param name="Type">Property type</param>
        public DataControl(Control Source, PropertyInfo Property, int Type)
        {
            this.Source = Source;
            this.Property = Property;
            this.Type = Type;
        }

        /// <summary>
        /// Updates the user's property based on the value in the control
        /// </summary>
        /// <param name="user">The user whose properties to update</param>
        public void UpdateUser(ref User user)
        {
            Property.SetValue(user, GetValue());
        }

        /// <summary>
        /// Updates the control based on user's property
        /// </summary>
        /// <param name="user">User whose properties to read</param>
        public void UpdateControl(ref User user)
        {
            object value = Property.GetValue(user);
            switch (Type)
            {
                case TYPE_STRING:
                    Source.Text = (string)value;
                    break;
                case TYPE_INT:
                case TYPE_DOUBLE:
                    ((NumericUpDown)Source).Value = int.Parse(value.ToString());
                    break;
                case TYPE_BOOL:
                    ((CheckBox)Source).Checked = (bool)value;
                    break;
                case TYPE_DATE:
                    ((DateTimePicker)Source).Value = (DateTime)value;
                    break;
            }
        }

        /// <summary>
        /// Gets the value from the control.
        /// </summary>
        /// <returns>The value from the control</returns>
        private object GetValue()
        {
            switch (Type)
            {
                case TYPE_STRING: return Source.Text;
                case TYPE_INT: return (int)((NumericUpDown)Source).Value;
                case TYPE_BOOL: return ((CheckBox)Source).Checked;
                case TYPE_DATE: return ((DateTimePicker)Source).Value;
                case TYPE_DOUBLE: return (double)((NumericUpDown)Source).Value;
                default: return null;
            }
        }

    }
}