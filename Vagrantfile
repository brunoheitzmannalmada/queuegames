Vagrant.configure("2") do |config|
  config.vm.box = "ubuntu/trusty64"
  config.vm.hostname = "queuegames-server"

  config.vm.network "private_network", ip: "192.168.0.10"

  config.vm.provision "ansible" do |ansible|
     ansible.playbook = "QueueGames-playbook.yaml"
  end
end
