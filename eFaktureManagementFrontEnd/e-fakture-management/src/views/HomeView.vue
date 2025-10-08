<template>
  <div class="home card flex flex-col align-middle justify-center">
    <img alt="Vue logo" src="../assets/logo.png">
    <HelloWorld msg="Welcome to Your Vue.js App" />

    <h1>Random Invoice Table</h1>
    <div class="controls">
      <button id="downloadCsv">Export as CSV</button>
      <button class="secondary" id="copyHtml">Copy HTML to Clipboard</button>
      <div style="margin-left:auto; color:#475569; font-size:13px;">Sample data — za testiranje</div>
    </div>

    <table id="invoiceTable" aria-label="Invoices">
      <thead>
        <tr>
          <th>Invoice #</th>
          <th>Date</th>
          <th>Customer Name</th>
          <th>Item Description</th>
          <th class="right">Quantity</th>
          <th class="right">Unit Price (€)</th>
          <th class="right">Total (€)</th>
          <th>Status</th>
        </tr>
      </thead>
      <tbody>
        <tr class="paid">
          <td data-label="Invoice #">INV-10234</td>
          <td data-label="Date">2025-09-15</td>
          <td data-label="Customer Name">Petar Petrović</td>
          <td data-label="Item Description">Office Chair</td>
          <td data-label="Quantity" class="right">2</td>
          <td data-label="Unit Price (€)" class="right">85.00</td>
          <td data-label="Total (€)" class="right">170.00</td>
          <td data-label="Status"><span class="status paid">Paid</span></td>
        </tr>
        <tr class="pending">
          <td data-label="Invoice #">INV-10235</td>
          <td data-label="Date">2025-09-18</td>
          <td data-label="Customer Name">Marija Marković</td>
          <td data-label="Item Description">Monitor 24"</td>
          <td data-label="Quantity" class="right">1</td>
          <td data-label="Unit Price (€)" class="right">145.00</td>
          <td data-label="Total (€)" class="right">145.00</td>
          <td data-label="Status"><span class="status pending">Pending</span></td>
        </tr>
        <tr class="paid">
          <td data-label="Invoice #">INV-10236</td>
          <td data-label="Date">2025-09-20</td>
          <td data-label="Customer Name">Jovan Jovanović</td>
          <td data-label="Item Description">USB-C Docking Station</td>
          <td data-label="Quantity" class="right">3</td>
          <td data-label="Unit Price (€)" class="right">59.99</td>
          <td data-label="Total (€)" class="right">179.97</td>
          <td data-label="Status"><span class="status paid">Paid</span></td>
        </tr>
        <tr class="overdue">
          <td data-label="Invoice #">INV-10237</td>
          <td data-label="Date">2025-09-21</td>
          <td data-label="Customer Name">Nikola Nikolić</td>
          <td data-label="Item Description">Laptop Stand</td>
          <td data-label="Quantity" class="right">1</td>
          <td data-label="Unit Price (€)" class="right">39.50</td>
          <td data-label="Total (€)" class="right">39.50</td>
          <td data-label="Status"><span class="status overdue">Overdue</span></td>
        </tr>
        <tr class="paid">
          <td data-label="Invoice #">INV-10238</td>
          <td data-label="Date">2025-09-25</td>
          <td data-label="Customer Name">Ana Anđelković</td>
          <td data-label="Item Description">Mechanical Keyboard</td>
          <td data-label="Quantity" class="right">2</td>
          <td data-label="Unit Price (€)" class="right">99.90</td>
          <td data-label="Total (€)" class="right">199.80</td>
          <td data-label="Status"><span class="status paid">Paid</span></td>
        </tr>
        <tr class="pending">
          <td data-label="Invoice #">INV-10239</td>
          <td data-label="Date">2025-09-26</td>
          <td data-label="Customer Name">Jelena Janković</td>
          <td data-label="Item Description">Wireless Mouse</td>
          <td data-label="Quantity" class="right">4</td>
          <td data-label="Unit Price (€)" class="right">24.99</td>
          <td data-label="Total (€)" class="right">99.96</td>
          <td data-label="Status"><span class="status pending">Pending</span></td>
        </tr>
        <tr class="paid">
          <td data-label="Invoice #">INV-10240</td>
          <td data-label="Date">2025-09-28</td>
          <td data-label="Customer Name">Stefan Stojanović</td>
          <td data-label="Item Description">Laptop Bag</td>
          <td data-label="Quantity" class="right">1</td>
          <td data-label="Unit Price (€)" class="right">49.00</td>
          <td data-label="Total (€)" class="right">49.00</td>
          <td data-label="Status"><span class="status paid">Paid</span></td>
        </tr>
        <tr class="paid">
          <td data-label="Invoice #">INV-10241</td>
          <td data-label="Date">2025-10-01</td>
          <td data-label="Customer Name">Ivana Ilić</td>
          <td data-label="Item Description">HDMI Cable 2m</td>
          <td data-label="Quantity" class="right">5</td>
          <td data-label="Unit Price (€)" class="right">7.99</td>
          <td data-label="Total (€)" class="right">39.95</td>
          <td data-label="Status"><span class="status paid">Paid</span></td>
        </tr>
        <tr class="pending">
          <td data-label="Invoice #">INV-10242</td>
          <td data-label="Date">2025-10-02</td>
          <td data-label="Customer Name">Đorđe Dimitrijević</td>
          <td data-label="Item Description">Ergonomic Mouse Pad</td>
          <td data-label="Quantity" class="right">2</td>
          <td data-label="Unit Price (€)" class="right">12.50</td>
          <td data-label="Total (€)" class="right">25.00</td>
          <td data-label="Status"><span class="status pending">Pending</span></td>
        </tr>
        <tr class="paid">
          <td data-label="Invoice #">INV-10243</td>
          <td data-label="Date">2025-10-04</td>
          <td data-label="Customer Name">Luka Lukić</td>
          <td data-label="Item Description">Portable SSD 1TB</td>
          <td data-label="Quantity" class="right">1</td>
          <td data-label="Unit Price (€)" class="right">129.00</td>
          <td data-label="Total (€)" class="right">129.00</td>
          <td data-label="Status"><span class="status paid">Paid</span></td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'HomeView',
  components: {
    HelloWorld
  }
}
</script>
