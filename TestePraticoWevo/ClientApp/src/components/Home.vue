<template>
    <div class="hello">
        <h1>{{ msg }}</h1>
        <img src="../assets/logo.png" />
        <p>
            Feito em Vue JS 3.0 e .NET 5
        </p>
        <p>
            Prova pratica de Marlon Braga para o cargo de Desenvolvedor Pleno da Meta.
        </p>
        <h3>Manipular API pelo Front-End</h3>
        <p>
            <router-link :to="{ name: 'Users' }" class="btn btn-outline-success">Tabela de Usuarios</router-link>
        </p>
        <h3>Manipular diretamente API</h3>
        <p>
            <ul>
                <li><a target="_blank" href="api/user"><span class="badge bagde-secondary"> [GET] /api/user</span></a></li>
                <li><a target="_blank" href="api/user/2"><span class="badge bagde-secondary"> [GET] /api /user/2</span></a></li>
                <li><span class="badge bagde-secondary">[POST] /api/user</span></li>
                <li><span class="badge bagde-secondary">[PUT] /api/user/2</span></li>
                <li><span class="badge bagde-secondary">[DELETE] /api/user/2</span></li>
                <li><span class="badge bagde-secondary">[DELETE] /api/user</span></li>
            </ul>
        </p>
        <h3>Código do projeto</h3>
        <p>
            <a target="_blank" href="https://github.com/marlonbraga/TestePraticoMeta/" class="btn btn-outline-success">GitHub</a>
        </p>
    </div>
</template>

<script>
export default {
  name: 'Home',
  props: {
    msg: String
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
  padding: 20px;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
