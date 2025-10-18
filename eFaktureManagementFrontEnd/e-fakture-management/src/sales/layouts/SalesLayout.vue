<script setup>
import AppHeader from '@/sales/navigation/AppHeader.vue';
import SalesNavBar from '@/sales/navigation/NavBar.vue';

import { ref } from 'vue'

var sidebar =ref(false);
</script>

<template>
    <SalesNavBar v-model="sidebar"></SalesNavBar>
    <AppHeader v-model="sidebar"></AppHeader>

    <v-main app>
        <slot></slot>
    </v-main>
    <v-footer app>
        eFaktureManagement © 2025
    </v-footer>
</template>

<style lang="scss"></style>