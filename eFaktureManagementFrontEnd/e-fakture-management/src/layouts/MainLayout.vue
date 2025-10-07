<script setup>
import AppHeader from '@/components/navigation/AppHeader.vue';


</script>

<template>
    <v-app>
        <v-layout class="flex flex-col h-screen">

            <AppHeader class="shrink-0"></AppHeader>
            <v-main class="grow min-h-0 overflow-auto">
                <slot></slot>
            </v-main>
            <!-- <v-footer class="shrink-0 h-min">

                eFaktureManagement © 2025
            </v-footer> -->
        </v-layout>

    </v-app>
</template>

<style lang="scss">
#app {
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
}

nav {
    padding: 30px;

    a {
        font-weight: bold;
        color: #2c3e50;

        &.router-link-exact-active {
            color: #42b983;
        }
    }
}
</style>