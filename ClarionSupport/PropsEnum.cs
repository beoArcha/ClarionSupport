using System;
using System.Collections;
using System.Collections.Generic;

namespace ClarionSupport
{
    internal class PropsEnum : ClarionProperties, IEnumerator
    {
        public int position = -1;
        private int myEnumMemberCount = Enum.GetNames(typeof(ClarionProps)).Length;
        private List<string> finalList = new List<string>();

        public object Current
        {
            get
            {
                return Enum.ToObject(typeof(ClarionProps), position);
            }
        }

        public int CurrentPostion
        {
            get { return position + 1; }
        }

        public string[] PropsArray
        {
            get
            {
                try
                {
                    finalList.Clear();
                    while (MoveNext())
                    {
                        finalList.Add("Prop:" + Current.ToString());
                    }
                    return finalList.ToArray();
                }
                catch (Exception)
                {
                    return null;
                    throw new Exception("Proprieties list error");
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < myEnumMemberCount);
        }

        public bool MoveNextAutoReset()
        {
            if (position + 1 < myEnumMemberCount)
            {
                position++;
            }
            else
            {
                Reset();
            }
            return true;
        }

        public void Reset()
        {
            position = -1;
        }
    }

    public class ClarionProperties
    {
        public enum ClarionProps
        {
            absolute,
            acceptall,
            active,
            addref,
            alias,
            align,
            at,
            auto,
            autopaper,
            autosize,
            binary,
            boxed,
            check,
            @checked,
            clientx,
            clienty,
            clip,
            color,
            cursor,
            dim,
            disable,
            enabled,
            fontname,
            fontsize,
            fontstyle,
            format,
            gray,
            height,
            hide,
            hint,
            hlp,
            hscroll,
            hscrollpos,
            hstmt,
            icon,
            iconize,
            iconlist,
            imagebits,
            left,
            mark,
            mask,
            max,
            maxheight,
            maximize,
            maxstatements,
            maxwidth,
            messagehook,
            meta,
            min,
            minheight,
            minwidth,
            mm,
            modal,
            msg,
            selected,
            selectedcolor,
            selectedfillcolor,
            selectinterface,
            selend,
            selstart,
            size,
            sizemode,
            skip,
            text,
            textalign,
            touched,
            truevalue,
            type,
            up,
            update,
            value,
            vcr,
            vcrfeq,
            visible,
            width,
            Xpos,
            Ypos,
        }
    }
}