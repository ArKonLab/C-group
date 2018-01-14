using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;


namespace WaitForIt
{
	class AnimationLT: DoubleAnimationUsingKeyFrames
	{
		DiscreteDoubleKeyFrame keyFrame1;
		DiscreteDoubleKeyFrame keyFrame2;
		DiscreteDoubleKeyFrame keyFrame3;
		DiscreteDoubleKeyFrame keyFrame4;
		DiscreteDoubleKeyFrame keyFrame5;
		DiscreteDoubleKeyFrame keyFrame6;

		public AnimationLT(Egg egg)
		{
			keyFrame1 = new DiscreteDoubleKeyFrame();
			keyFrame1.KeyTime = TimeSpan.FromSeconds(1);
			keyFrame1.Value = Canvas.GetTop(egg);
			KeyFrames.Add(keyFrame1);

			keyFrame2 = new DiscreteDoubleKeyFrame();
			keyFrame2.KeyTime = TimeSpan.FromSeconds(2);
			keyFrame2.Value = Canvas.GetTop(egg) + 2;
			KeyFrames.Add(keyFrame2);

			keyFrame3 = new DiscreteDoubleKeyFrame();
			keyFrame3.KeyTime = TimeSpan.FromSeconds(3);
			keyFrame3.Value = Canvas.GetTop(egg) + 23;
			KeyFrames.Add(keyFrame3);

			keyFrame4 = new DiscreteDoubleKeyFrame();
			keyFrame4.KeyTime = TimeSpan.FromSeconds(4);
			keyFrame4.Value = Canvas.GetTop(egg) + 22;
			KeyFrames.Add(keyFrame4);

			keyFrame5 = new DiscreteDoubleKeyFrame();
			keyFrame5.KeyTime = TimeSpan.FromSeconds(5);
			keyFrame5.Value = Canvas.GetTop(egg) + 43;
			KeyFrames.Add(keyFrame5);

			keyFrame6 = new DiscreteDoubleKeyFrame();
			keyFrame6.KeyTime = TimeSpan.FromSeconds(6);
			keyFrame6.Value = Canvas.GetTop(egg) + 53;
			KeyFrames.Add(keyFrame6);
		}
	}
}
