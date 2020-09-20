using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using The_greatest_RPG_in_human_history.Entities;

namespace The_greatest_RPG_in_human_history
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player _player;
        private Enemy _enemy;
        public MainWindow()
        {
            InitializeComponent();
            Attack.Content = "Attacker attacked";
            Attack.Click += Button_Click;
            _player = new Player(20, 125, "dood");
            _enemy = new Enemy(15, 125, "Man");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!_player.IsDead() && !_enemy.IsDead())
            {
                _enemy.DealsDamage(_player);
                _player.DealsDamage(_enemy);
            }
            var playerstatus = _player.Status();
            var enemystatus = _enemy.Status();
            if (_player.IsDead())
            {
                playerstatus = _player.PrintDeathMessage();
            }
            if (_enemy.IsDead())
            {
                enemystatus = "enemy is dead";
            }
               
            Stats.Content = $"{playerstatus}\t\t\t{enemystatus}";
        }
    }
}
