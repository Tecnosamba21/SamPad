using SamPad.UndoRedo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamPad.Edit_Operation
{
    public class EditOperation
    {
        private UndoRedoClass data;

        private bool txtAreaChangeRequired;

        public EditOperation()
        {
            data = new UndoRedoClass();
        }

        public bool TxtAreaChangeRequired;

        public string DateTime_Now()
        {
            return DateTime.Now.ToString();
        }

        public string UndoClicked()
        {
            TxtAreaChangeRequired = false;
            return data.Undo();
        }
        public string RedoClicked()
        {
            TxtAreaChangeRequired = false;
            return data.Redo();
        }

        public void Add_UndoRedo(string item)
        {
            data.AddItem(item);
        }

        public bool CanUndo()
        {
            return data.CanUndo();
        }

        public bool CanRedo()
        {
            return data.CanRedo();
        }

    }
}
