<script>



export default {

    name: "ListItem",
    props: {
        group: Object
    }
}


</script>



<template>

    <v-list-group v-if="group.items && group.items.length > 0" :value="group.title">
        <template v-slot:activator="{ props }">

            <v-list-item v-bind="props" :title="group.title" :prepend-icon="group.icon" />
        </template>

        <template v-for="(item, i) in group.items" :key="i">
            <router-link v-if="item.to" :to="item.to">
                <v-list-item :title="item.title" :prepend-icon="item.icon" />
            </router-link>
            <v-list-item v-else :title="item.title" :prepend-icon="item.icon" />
        </template>
    </v-list-group>
    <v-list-item v-else :title="group.title" :prepend-icon="group.icon" />


</template>