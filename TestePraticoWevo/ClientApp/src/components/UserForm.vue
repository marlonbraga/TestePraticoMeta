<template>
    <h1 id="tableLabel">Adicionar/Editar Usuario</h1>

    <p>Dados persistidos no banco MySQL</p>

    <p v-if="!users"><em>Carregando...</em></p>

    <table class='table table-striped' aria-labelledby="tableLabel">
        <tbody>
            <tr>
                <th>Nome</th>
                <td><input type="text" name="Name" id="Name" placeholder="Dummy" value=""/></td>
            </tr>
            <tr>
                <th>CPF</th>
                <td><input type="text" name="Cpf" id="Cpf" placeholder="000.000.000-00" value="" /></td>
            </tr>
            <tr>
                <th>Email</th>
                <td><input type="email" name="Email" id="Email" placeholder="dummy@email.com" value="" /></td>
            </tr>
            <tr>
                <th>Telefone</th>
                <td><input type="text" name="Phone" id="Phone" placeholder="+55 21 000.000.000" value="" /></td>
            </tr>
            <tr>
                <th>Sexo</th>
                <td><input type="number" name="Gender" id="Gender" placeholder="0 ou 1" value="" /></td>
            </tr>
            <tr>
                <th>Data de Nascimento</th>
                <td><input type="datetime" name="BirthDate" id="BirthDate" placeholder="00/00/0000" value="" /></td>
            </tr>
        </tbody>
    </table>
    <router-link :to="{ name: 'Users' }" v-on:click="save" class="btn btn-success">Salvar</router-link>
</template>


<script>
    import axios from 'axios'
    export default {
        name: "UserForm",
        data() {
            return {
                idUser: null,
                users: []
            }
        },
        methods: {
            getUser(id) {
                axios.get('/api/user/' + id)
                    .then((response) => {
                        this.user = response.data;
                        document.getElementById("Name").value = this.user.name,
                            document.getElementById("Cpf").value = this.user.cpf,
                            document.getElementById("Email").value = this.user.email,
                            document.getElementById("Phone").value = this.user.phone,
                            document.getElementById("Gender").value = this.user.gender,
                            document.getElementById("BirthDate").value = this.user.birthDate
                    })
                    .catch(function (error) {
                        alert(error);
                    });
            },
            save() {
                if (this.idUser)
                    this.putUser(this.idUser);
                else
                    this.postUser();
            },
            putUser(idUser) {
                let targetUser = {
                    id: parseInt(idUser),
                    name: `${document.getElementById("Name").value}`,
                    cpf: `${document.getElementById("Cpf").value}`,
                    email: `${document.getElementById("Email").value}`,
                    phone: `${document.getElementById("Phone").value}`,
                    gender: parseInt(document.getElementById("Gender").value),
                    birthDate: `${document.getElementById("BirthDate").value}`
                };
                console.log(targetUser);
                axios.put('/api/user/' + idUser, targetUser)
                    .then((response) => {
                        this.users = response.data;
                    })
                    .catch(function (error) {
                        alert(error);
                    });
            },
            postUser() {
                let newUser = {
                    name: `${document.getElementById("Name").value}`,
                    cpf: `${document.getElementById("Cpf").value}`,
                    email: `${document.getElementById("Email").value}`,
                    phone: `${document.getElementById("Phone").value}`,
                    gender: parseInt(document.getElementById("Gender").value),
                    birthDate: `${document.getElementById("BirthDate").value}`
                };
                console.log(newUser);
                axios.post('/api/user', newUser)
                    .then((response) => {
                        this.users = response.data;
                    })
                    .catch(function (error) {
                        alert(error);
                    });
            },
        },
        mounted() {
            const queryString = window.location.search;
            const urlParams = new URLSearchParams(queryString);
            if (urlParams.has('id')) {
                this.idUser = urlParams.get('id');
                this.getUser(urlParams.get('id'));
            }
        }
    }
</script>