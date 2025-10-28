<script setup>
import AppHeader from '@/components/navigation/AppHeader.vue';

import { ref } from 'vue'
import NavBar from '../navigation/PurchaseNavBar.vue';

var sidebar =ref(false);
</script>

<template>
    <NavBar v-model="sidebar"></NavBar>
    <AppHeader v-model="sidebar"></AppHeader>

    <v-main app>
        <slot></slot>
    </v-main>
</template>

<style lang="scss"></style>