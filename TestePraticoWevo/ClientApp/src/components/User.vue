<template>
    <h1 id="tableLabel">Usuarios</h1>

    <p>Dados persistidos no banco MySQL</p>

    <p v-if="!users"><em>Carregando...</em></p>

    <table class='table table-striped' aria-labelledby="tableLabel" v-if="users">
        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>CPF</th>
                <th>Email</th>
                <th>Telefone</th>
                <th>Sexo</th>
                <th>Data de Nascimento</th>
                <th> </th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="user of users" v-bind:key="user.id">
                <td>{{ user.id }}</td>
                <td>{{ user.name }}</td>
                <td>{{ user.cpf }}</td>
                <td>{{ user.email }}</td>
                <td>{{ user.phone }}</td>
                <td>{{ user.gender }}</td>
                <td>{{ user.birthDate }}</td>
                <td>
                    <router-link :to="'/UserForm?id='+user.id" class="btn btn-primary">Editar</router-link>
                    <button v-on:click="deleteUser(user.id)" class="btn btn-danger">Deletar</button>
                </td>
            </tr>
        </tbody>
    </table>

    <router-link :to="{ name: 'UserForm' }" class="btn btn-success"><i class="fas fa-plus"></i>Adicionar</router-link>
</template>


<script>
    import axios from 'axios'
    export default {
        name: "Users",
        data() {
            return {
                users: []
            }
        },
        methods: {
            getUsers() {
                axios.get('/api/user')
                    .then((response) => {
                        this.users = response.data;
                    })
                    .catch(function (error) {
                        alert(error);
                    });
            },
            deleteUser(id) {
                axios.delete('/api/user/'+id)
                    .then((response) => {
                        this.users = response.data;
                    })
                    .catch(function (error) {
                        alert(error);
                    });
            }
        },
        mounted() {
            this.getUsers();
        }
    }
</script>