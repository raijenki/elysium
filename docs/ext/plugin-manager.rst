.. _plugin-manager:

Gerenciador de Plugins
==========================

O **Gerenciador de Plugins** ou **Plugin Manager** é um gerenciador capaz de instalar novas tecnologias na sua Elysium.NET de maneira automática. Sem a necessidade de tutoriais que acabam por requerir muito trabalho tanto do autor como o do usuário. A proposta do gerenciador é a capacidade de implementar modificações da Elysium.NET através de um simples clique.

.. image:: ext/images/plugin.png
    :align: center
    :alt: alternate text

Utilidades
==========================
* Criar plugins de forma dinâmica definindo a ação efetuada com cada bloco de código.
* Exibir e instalar plugins verificados e disponibilizados pela comunidade.
* Publicar plugins em prol de colaborar com a comunidade.
* Permitir uma instalação manual do plugin em forma de tutorial.

Como utilizar
===========================

**Instalando o Plugin Manager**
O Plugin Manager vem acompanhado de um instalador. Após a instalação, é possível abri-lo através do Menu Iniciar.

**Instalando um novo Plugin**
Os plugins verificados da comunidade são automaticamente listados na tela principal do Plugin Manager, permitindo o download e instalação dos mesmos a qualquer momento utilizando de um simples clique no botão "Download". Da mesma forma, qualquer plugin externo pode ser instalado através do menu **Arquivo -> Instalar** e selecionando o arquivo .plugin.

.. image:: ext/images/install.png
    :align: center
    :alt: alternate text

Para instalar o plugin, basta configurar a pasta destino do projeto na caixa de texto superior e clicar no botão "Instalar". Observando de que esta pasta é a pasta raiz de um projeto Elysium.NET, antes da pasta "Source".

**Alerta:** É altamente recomendável de que um backup do código seja feito antes de cada instalação e o Visual Studio se encontre fechado.

**Lidando com possíveis erros**
Alguns plugins podem ter problemas ao serem instalados em sua Elysium, principalmente em casos onde o desenvolvedor a modificou bastante e impediu o Plugin Manager de encontrar algum trecho de código específico. Neste caso, a instalação ressaltará o número de erros e permitirá que o usuário veja a lista de ações do plugin, destacando as ações falhas e seu respectivo problema. Atualmente, o usuário terá de seguir a orientação da ação manualmente para efetuar a correção.

.. image:: ext/images/manual.png
    :align: center
    :alt: alternate text

**Criando um novo Plugin**
Os plugins trabalham de maneira similar a um autor escrevendo um tutorial. Instruções como "Procure por tal trecho de código e substitua-o por isso" ou "Encontre a função X e abaixo dela insira este trecho" são descritas de maneira automatizada pelo Plugin Manager como uma lista de ações.

.. image:: ext/images/create.png
    :align: center
    :alt: alternate text

A região esquerda contém a lista de ações do plugin, enquanto a região central direita descreve os dados da ação correspondente. A aba "Localização" permite que o usuário oriente onde a ação deverá atuar, informando a solução, classe, opcionalmente uma possível estrutura (como uma Structure, Sub, Function, etc...), ou até mesmo um bloco de código específico, e apenas neste ultimo caso, é possível selecionar se o seu código customizado será adicionado após o bloco em questão, antes ou o substituirá. A aba "Código" irá conter seu código customizado.

**Alerta:** É recomendável testar o plugin em uma Elysium.NET sem modificações para validar sua compatibilidade. O critério de validação dos plugins para a lista da comunidade utilizam de uma Elysium.NET limpa mais recente como teste, caso contrário, o plugin não será validado ao público.

**Publicando um plugin**
Após concluir o plugin, o usuário pode optar por compartilhá-lo com a comunidade da MMODEV. Para isso, o link https://www.plugins.mmodev.com.br/ é disponibilizado ao público para submeter seus respectivos plugins.