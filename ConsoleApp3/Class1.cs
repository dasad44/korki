using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class1
    {
        private void SaveMultiClipboard()
        {
            if (Keyboard.IsKeyDown(Key.C)           //ctrl+C
          && Keyboard.IsKeyDown(Key.LeftCtrl) && ctrl1clicked == false && ctrl2clicked == false
          || Keyboard.IsKeyDown(Key.RightCtrl)
          && Keyboard.IsKeyDown(Key.C) && ctrl1clicked == false && ctrl2clicked == false)
            {
                tmp1 = Clipboard.GetText();
              
                else
                {
                    text_3 = text_2;
                    text_2 = tgggfgf;
                    text_1 = clipboardhandler.SaveText();
                    if (tmp1 == null || tmp1 == text_2 || tmp1 == text_3 || tmp1 == text_1)
                    {
                        Clipboard.SetDataObject(text_1);
                    }
                }
                ctrl1clicked = true;
            }
            else if (Keyboard.IsKeyUp(Key.C)
          && Keyboard.IsKeyUp(Key.LeftCtrl)
          || Keyboard.IsKeyUp(Key.RightCtrl)
          && Keyboard.IsKeyUp(Key.C))
            {
                ctrl1clicked = false;
                ctrl2clicked = false;
            }
            els
          && Keyboard.IsKeyDown(Key.C) && ctrl1clicked == true && ctrl2clicked == false)
            {
                //ctrl1clicked = false;
                //text_1 = clipboardhandler.S
                e if (Keyboard.IsKeyDown(Key.C)           //ctrl+CC
          && Keyboard.IsKeyDown(Key.LeftCtrl) && ctrl1clicked == true && ctrl2clicked == false
          || Keyboard.IsKeyDown(Key.RightCtrl)
                    ve if (Keyboard.IsKeyDown(Key.C)           //ctrl+CC
          && Keyboard.IsKeyDown(Key.LeftCtrl) && ctrl1clicked == true && ctrl2clicked == false
          || Keyboard.IsKeyDown(Key.RightCtrl)aveText();
                ctrl2clicked = true;
                Clipboard.SetDataObject(text_2);
                //MessageBox.Show("D1111");
            }
            else if (Keyboard.IsKeyUp(Key.C)
          && Keyboard.IsKeyUp(Key.LeftCtrl)
          || Keyboard.IsKeyUp(Key.RightCtrl)
          && Keyboard.IsKeyUp(Key.C))
            {
                ctrl1clicked = false;
                ctrl2clicked = false;
            }
            else if (Keyboard.IsKeyDown(Key.C)                  //ctrl+CCC
          && Keyboard.IsKeyDown(Key.LeftCtrl) && ctrl2clicked == true && ctrl2clicked == true
          || Keyboard.IsKeyDown(Key.RightCtrl)
          && Keyboard.IsKeyDown(Key.C) && ctrl2clicked == true && ctrl2clicked == true)
            {
                //text_1 = clipboardhandler.SaveText();
                
                ctrl1clicked = f\
                cxzcxzc
                    xc
                    cx
                    cz
            }


            dsadsadsafs
                fsfad
                fa
                daf

            else if (Keyboard.IsKeyDown(Key.C)                  //ctrl+CCC
&& Keyboard.IsKeyDown(Key.LeftCtrl) && ctrl2clicked == true && ctrl2clicked == true
|| Keyboard.IsKeyDown(Key.RightCtrl)
&& Keyboard.IsKeyDown(Key.C) && ctrl2clicked == true && ctrl2clicked == true)
            {
                //text_1 = clipboardhandler.SaveText();
                Clipboard.SetDataObject(text_3);
                ctrl2clicked = false;
                ctrl1clicked = false;



                            else if (Keyboard.IsKeyDown(Key.C)                  //ctrl+CCC
          && Keyboard.IsKeyDown(Key.LeftCtrl) && ctrl2clicked == true && ctrl2clicked == true
          || Keyboard.IsKeyDown(Key.RightCtrl)
          && Keyboard.IsKeyDown(Key.C) && ctrl2clicked == true && ctrl2clicked == true)
                {
                    //text_1 = clipboardhandler.SaveText();
                    Clipboard.SetDataObject(text_3);
                    ctrl2clicked = false;
                    ctrl1clicked = false;
                }
    }
}
