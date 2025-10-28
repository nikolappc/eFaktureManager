<script setup>
import AppHeader from '@/components/navigation/AppHeader.vue';

import { ref } from 'vue'

var sidebar =ref(false);
</script>

<template>
    <AppHeader v-model="sidebar"></AppHeader>

    <v-main app>
        <slot></slot>
    </v-main>
</template>

<style lang="scss"></style>