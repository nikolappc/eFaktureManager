<script setup>
import AppHeader from '@/components/navigation/AppHeader.vue';
import NavBar from '@/components/navigation/NavBar.vue';

import { ref } from 'vue'

var sidebar =ref(false);
</script>

<template>
    <NavBar v-model="sidebar"></NavBar>
    <AppHeader v-model="sidebar"></AppHeader>

    <v-main app>
        <slot></slot>
    </v-main>
    <v-footer app>
        eFaktureManagement © 2025
    </v-footer>
</template>

<style lang="scss"></style>