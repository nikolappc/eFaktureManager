<template>
  <div class="flex flex-col h-full">
    <v-select label="Page Size" v-model="pageSizeSelect" :hint="pageSizeSelect.title" item-title="title"
      item-value="size" :items="pageSizeOptions" class="mb-4" />

    <div class="min-h-0 grow overflow-auto">
      <v-table striped="even" height="100%" fixed-header>
        <thead>
          <tr v-if="Columns && Columns.Keys.length > 0">
            <th v-for="column in Columns" :key="column.Name">
              {{ column.Name }}
            </th>
          </tr>
          <tr v-else-if="modelValue.length > 0">
            <th v-for="(value, key) in modelValue[0]" :key="key">
              {{ key }}
            </th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="item in modelValue" :key="item.id">
            <template v-if="Columns && Columns.Keys.length > 0">
              <td v-for="column in Columns" :key="column.Name">
                {{ item[column.Field] }}
              </td>
            </template>
            <template v-else-if="modelValue.length > 0">
              <td v-for="(value,key) in item" :key="key">
                {{ item[key] }}
              </td>
            </template>
            <!-- <td>
              <v-btn>
                <v-icon icon="mdi-file-pdf-box"></v-icon>
              </v-btn>
              <v-btn>
                <v-icon icon="mdi-file-xml-box"></v-icon>
              </v-btn>
            </td> -->
          </tr>
        </tbody>
      </v-table>
    </div>

    <v-pagination :length="totalPages" v-model="pageValue" class="grow-0 shrink-0 mt-4" />
  </div>
</template>

<script>
import { shallowRef, computed, watch } from 'vue'

export default {
  name: "PagingTable",
  props: {
    modelValue: Array,
    totalPages: Number,
    page: Number,
    filtered: Number,
    total: Number,
    Columns: Object
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