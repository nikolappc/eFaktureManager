<template>
  <div class="flex flex-col h-full">
    <v-select
      label="Page Size"
      v-model="pageSizeSelect"
      :hint="pageSizeSelect.title"
      item-title="title"
      item-value="size"
      :items="pageSizeOptions"
      class="mb-4"
    />

    <div class="min-h-0 grow overflow-auto">
      <v-table striped="even" height="100%" fixed-header>
        <thead>
          <tr>
            <th class="text-left">Name</th>
            <th class="text-left">Calories</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="item in modelValue" :key="item.name">
            <td>{{ item.name }}</td>
            <td>{{ item.calories }}</td>
          </tr>
        </tbody>
      </v-table>
    </div>

    <v-pagination
      :length="totalPages"
      v-model="pageValue"
      class="grow-0 shrink-0 mt-4"
    />
  </div>
</template>

<script>
import { shallowRef, computed, watch } from 'vue'

export default {
  props: {
    modelValue: Array,
    totalPages: Number,
    page: Number,
    filtered: Number,
    total: Number,
    // pageSize: Number
  },
  emits: ['updatePage', 'updatePageSize'],
  setup(props, { emit }) {
    const pageValue = computed({
      get: () => props.page,
      set: (val) => emit('updatePage', val)
    })

    const pageSizeSelect = shallowRef({ title: '25 per page', size: 25 })

    const pageSizeOptions = [
      { title: '10 per page', size: 10 },
      { title: '25 per page', size: 25 },
      { title: '50 per page', size: 50 },
      { title: '100 per page', size: 100 },
      { title: '200 per page', size: 200 }
    ]

    watch(pageSizeSelect, (val) => {
      emit('updatePageSize', val.size)
    })

    return {
      pageValue,
      pageSizeSelect,
      pageSizeOptions
    }
  }
}
</script>