<script>
export default {
       props: ['message', 'userId'],

}
</script>

<template>
  <div class="flex flex-col h-full">


    <div class="min-h-0 grow overflow-auto">

      <v-table striped="even" height="100%" fixed-header>
        <thead>
          <tr>
            <th class="text-left">
              Name
            </th>
            <th class="text-left">
              Calories
            </th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="item in desserts" :key="item.name">
            <td>{{ item.name }}</td>
            <td>{{ item.calories }}</td>
          </tr>
        </tbody>
      </v-table>

    </div>

    <v-pagination :length="20" class="grow-0 shrink-0"></v-pagination>
  </div>
</template>
