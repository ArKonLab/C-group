using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WaitForIt
{
	class AnimationLTL: DoubleAnimationUsingKeyFrames
	{
		DiscreteDoubleKeyFrame keyFrame1;
		DiscreteDoubleKeyFrame keyFrame2;
		DiscreteDoubleKeyFrame keyFrame3;
		DiscreteDoubleKeyFrame keyFrame4;
		DiscreteDoubleKeyFrame keyFrame5;
		DiscreteDoubleKeyFrame keyFrame6;

		public AnimationLTL(Egg egg)
		{
			keyFrame1 = new DiscreteDoubleKeyFrame();
			keyFrame1.Value = Canvas.GetLeft(egg);
			KeyFrames.Add(keyFrame1);

			keyFrame2 = new DiscreteDoubleKeyFrame();
			keyFrame2.KeyTime = TimeSpan.FromSeconds(MainWindow.time * 1);
			keyFrame2.Value = Canvas.GetLeft(egg) + 30;
			KeyFrames.Add(keyFrame2);

			keyFrame3 = new DiscreteDoubleKeyFrame();
			keyFrame3.KeyTime = TimeSpan.FromSeconds(MainWindow.time * 2);
			keyFrame3.Value = Canvas.GetLeft(egg) + 39;
			KeyFrames.Add(keyFrame3);

			keyFrame4 = new DiscreteDoubleKeyFrame();
			keyFrame4.KeyTime = TimeSpan.FromSeconds(MainWindow.time * 3);
			keyFrame4.Value = Canvas.GetLeft(egg) + 78;
			KeyFrames.Add(keyFrame4);

			keyFrame5 = new DiscreteDoubleKeyFrame();
			keyFrame5.KeyTime = TimeSpan.FromSeconds(MainWindow.time * 4);
			keyFrame5.Value = Canvas.GetLeft(egg) + 104;
			KeyFrames.Add(keyFrame5);

			keyFrame6 = new DiscreteDoubleKeyFrame();
			keyFrame6.KeyTime = TimeSpan.FromSeconds(MainWindow.time * 5);
			keyFrame6.Value = Canvas.GetLeft(egg) + 119;
			KeyFrames.Add(keyFrame6);
		}
	}
}
