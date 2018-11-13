/*
   Copyright 2018 tkpphr

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */
using ProcessMemoryObserver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMemoryObserver.GUI.Forms
{
	public partial class OptionDialog : Form
	{
		private SpeechSynthesizer SpeechSynthesizer { get; set; }
		private InstalledVoice SelectedVoice { get; set; }
		private string[] VoiceNames { get; set; }

		public OptionDialog()
		{
			InitializeComponent();
			SpeechSynthesizer = new SpeechSynthesizer();
			VoiceNames = SpeechSynthesizer.GetInstalledVoices().Select(installedVoice => installedVoice.VoiceInfo.Name).ToArray();
			VoiceComboBox.SelectedIndexChanged -= VoiceComboBox_SelectedIndexChanged;
			VoiceComboBox.Items.AddRange(VoiceNames);
			VoiceComboBox.SelectedIndex = Array.IndexOf(VoiceNames, Settings.Default.TTSVoice);
			string voiceName = VoiceNames[VoiceComboBox.SelectedIndex];
			SelectedVoice = SpeechSynthesizer.GetInstalledVoices().First(installedVoice => installedVoice.VoiceInfo.Name == voiceName);
			LanguageLabel.Text = SelectedVoice.VoiceInfo.Culture.DisplayName;
			VoiceComboBox.SelectedIndexChanged += VoiceComboBox_SelectedIndexChanged;
			SpeechSynthesizer.SelectVoice(SelectedVoice.VoiceInfo.Name);
			RateTrackBar.Value = Settings.Default.TTSRate;
			RateValueLabel.Text = RateTrackBar.Value.ToString();
			VolumeTrackBar.Value = Settings.Default.TTSVolume;
			VolumeValueLabel.Text = VolumeTrackBar.Value.ToString();

		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);
			SpeechSynthesizer.SpeakAsyncCancelAll();
			SpeechSynthesizer.Dispose();
		}

		private void VoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string voiceName = VoiceNames[VoiceComboBox.SelectedIndex];
			SelectedVoice = SpeechSynthesizer.GetInstalledVoices().First(installedVoice => installedVoice.VoiceInfo.Name == voiceName);
			SpeechSynthesizer.SelectVoice(voiceName);
			Settings.Default.TTSVoice = voiceName;
			LanguageLabel.Text = SelectedVoice.VoiceInfo.Culture.DisplayName;
			if (CultureInfo.CurrentCulture.Name == SelectedVoice.VoiceInfo.Culture.Name)
			{
				SpeechSynthesizer.SpeakAsync(Resources.VoiceChanged);
			}
			else
			{
				SpeechSynthesizer.SpeakAsync(Resources.VoiceChangedDefault);
			}
		}

		private void RateTrackBar_Scroll(object sender, EventArgs e)
		{
			RateValueLabel.Text = RateTrackBar.Value.ToString();
			Settings.Default.TTSRate = RateTrackBar.Value;

			SpeechSynthesizer.SpeakAsyncCancelAll();
			SpeechSynthesizer.Rate = Settings.Default.TTSRate;
			if (CultureInfo.CurrentCulture.Name == SelectedVoice.VoiceInfo.Culture.Name)
			{
				SpeechSynthesizer.SpeakAsync(Resources.RateChanged);
			}
			else
			{
				SpeechSynthesizer.SpeakAsync(Resources.RateChangedDefault);
			}
		}

		private void VolumeTrackBar_Scroll(object sender, EventArgs e)
		{
			VolumeValueLabel.Text = VolumeTrackBar.Value.ToString();
			Settings.Default.TTSVolume = VolumeTrackBar.Value;
			SpeechSynthesizer.SpeakAsyncCancelAll();
			SpeechSynthesizer.Volume = Settings.Default.TTSVolume;
			if (CultureInfo.CurrentCulture.Name == SelectedVoice.VoiceInfo.Culture.Name)
			{
				SpeechSynthesizer.SpeakAsync(Resources.VolumeChanged);
			}
			else
			{
				SpeechSynthesizer.SpeakAsync(Resources.VolumeChangedDefault);
			}
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Settings.Default.Save();
			Close();
		}
	}
}
