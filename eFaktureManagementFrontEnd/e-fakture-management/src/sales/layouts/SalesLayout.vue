<script setup>
import AppHeader from '@/components/navigation/AppHeader.vue';

import { ref } from 'vue'
import SalesNavBar from '../navigation/SalesNavBar.vue';

var sidebar =ref(false);
</script>

<template>
    <SalesNavBar v-model="sidebar"></SalesNavBar>
    <AppHeader v-model="sidebar"></AppHeader>

    <v-main app>
        <slot></slot>
    </v-main>
   
</template>

<style lang="scss"></style>