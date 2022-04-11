import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import Users from "@/components/User.vue";
import UserForm from "@/components/UserForm.vue";

const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: "/Users",
        name: "Users",
        component: Users,
    },
    {
        path: "/UserForm",
        name: "UserForm",
        component: UserForm,
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;