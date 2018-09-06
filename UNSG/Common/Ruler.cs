using System;
using System.Drawing;

namespace UNSG
{
    public class Ruler
    {
        /// <summary>
        /// ルーラーの形態
        /// </summary>
        public enum RulerMode
        {
            Mode1,
            Mode2Red,
            Mode2Blue,
            Mode3,
            Mode4,

            /// <summary>
            /// 撃破
            /// </summary>
            Death
        }

        /// <summary>
        /// 形態
        /// </summary>
        public RulerMode Mode { get; set; }

        /// <summary>
        /// 残LP
        /// </summary>
        public int LP { get; set; }

        /// <summary>
        /// 経過ターン数
        /// </summary>
        public int Turn { get; set; }

        /// <summary>
        /// 残行動数
        /// </summary>
        public int Action { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Ruler()
        {
            Mode = RulerMode.Mode1;
            SetData(Mode);
            ResetAction(Mode);
        }

        /// <summary>
        /// ルーラーの状態初期化
        /// </summary>
        /// <param name="Mode">形態(1～4)</param>
        public void SetData(RulerMode SetMode)
        {
            switch (SetMode)
            {
                case RulerMode.Mode1:
                    this.Mode = SetMode;
                    Turn = 1;
                    LP = 22;
                    break;

                case RulerMode.Mode2Red:
                    LP = 16;
                    break;

                case RulerMode.Mode2Blue:
                    LP = 26;
                    break;

                case RulerMode.Mode3:
                    LP = 11;
                    break;

                case RulerMode.Mode4:
                    LP = 20;
                    break;

                case RulerMode.Death:
                    Action = 0;
                    LP = 0;
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// ルーラーの行動回数初期化
        /// </summary>
        /// <param name="Mode">形態(1～4)</param>
        public void ResetAction(RulerMode Mode)
        {
            switch (Mode)
            {
                case RulerMode.Mode1:
                    Action = 3;
                    break;

                case RulerMode.Mode2Red:
                    Action = 4;
                    break;

                case RulerMode.Mode2Blue:
                    Action = 4;
                    break;

                case RulerMode.Mode3:
                    Action = 5;
                    break;

                case RulerMode.Mode4:
                    Action = 7;
                    break;

                case RulerMode.Death:
                    Action = 0;
                    break;

                default:
                    break;
            }
        }

        public string Name
        {
            get
            {
                switch (Mode)
                {
                    case RulerMode.Mode1: return "第1形態";
                    case RulerMode.Mode2Red: return "第2形態(赤)";
                    case RulerMode.Mode2Blue: return "第2形態(青)";
                    case RulerMode.Mode3: return "第3形態";
                    case RulerMode.Mode4: return "最終形態";
                    case RulerMode.Death: return "撃破";
                    default: throw new Exception("来るわけないけどね");
                }
            }
        }

        public Color NameColor
        {
            get
            {
                switch (Mode)
                {
                    case RulerMode.Mode1: return SystemColors.ControlText;
                    case RulerMode.Mode2Red: return Color.FromArgb(237, 131, 32);
                    case RulerMode.Mode2Blue: return Color.FromArgb(61, 143, 222);
                    case RulerMode.Mode3:
                    case RulerMode.Mode4:
                    case RulerMode.Death:
                    default: return SystemColors.ControlText;
                }
            }
        }

        public bool IsDead => Mode == RulerMode.Death;

    }
}
