import React from 'react'
import Table from '../../Components/Table/Table'
import RatioList from '../../Components/RatioList/RatioList'
import { CompanyKeyMetrics } from '../../company'
import { testIncomeStatementData } from '../../Components/Table/testData'

type Props = {}

const tableConfig = [
  {
    label: "Market Cap",
    render: (company: any) => company.marketCapTTM,
    subTitle: "Total value of all a company's shares of stock",
  },
]

const DesignPage = (props: Props) => {
  return (
    <>
    <h1>JackFin Design Page</h1>
    <h2>This is JackFins design page this is where we'll house various design aspects of this app</h2>
    <Table data={testIncomeStatementData} config={tableConfig}/>
    <RatioList data ={testIncomeStatementData} config={tableConfig}/>
    </>
  )
}

export default DesignPage