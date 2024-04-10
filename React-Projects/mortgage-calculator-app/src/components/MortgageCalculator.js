import React, { useState } from 'react';
import './MortgageCalculator.css'

const MortgageCalculator = () => {
const [amount, setamount] = useState('');
const [interestRate, setInterestRate] = useState('');
const [loanTerm, setLoanTerm] = useState('');
const [downPayment, setDownPayment] = useState('');
const [monthlyPayment, setMonthlyPayment] = useState(null);
const [totalPayable, setTotalPayable] = useState(null);
const [totalInterest, setTotalInterest] = useState(null);
const [error, setError] = useState('');

const calculateMonthlyPayment = () => {
	if (!amount || !interestRate || !loanTerm) {
		setError('Please fill in all fields.');
		alert('Please fill all the fields !!!')
		setMonthlyPayment('');
		return;
	}


	const loanAmount = parseFloat(amount) - (downPayment ? parseFloat(downPayment) : 0);

	const r = parseFloat(interestRate) / 100 / 12;
	const n = parseFloat(loanTerm) * 12;
	
	const numerator = loanAmount * r * Math.pow(1 + r, n);
	const denominator = Math.pow(1 + r, n) - 1;

	const monthlyPayment = (numerator / denominator).toFixed(2);
	setMonthlyPayment(monthlyPayment);

	const totalPayable = (monthlyPayment * n).toFixed(2);
	setTotalPayable(totalPayable);

	const totalInterest = (totalPayable - loanAmount).toFixed(2);
	setTotalInterest(totalInterest);
	setError('');
};

return (
	<div className='container'>
	<h1>Mortgage Calculator</h1>
	<div className='main-cont'>
	<div className='label'>
		<label>
		Loan Amount (₹):
		<input
			type="number"
			value={amount}
			onChange={(e) => setamount(e.target.value)}
			placeholder='amount'
		/>
		</label>
	</div>
	<div className='label'>
		<label>
		Down Payment (₹):
		<input
			type="number"
			value={downPayment}
			onChange={(e) => setDownPayment(e.target.value)}
			placeholder='Down Payment'
		/>
		</label>
	</div>
	<div className='label'>
		<label>
		Rate of Interest (%):
		<input
			type="number"
			value={interestRate}
			onChange={(e) => setInterestRate(e.target.value)}
			placeholder='Annual Interest Rate'
		/>
		</label>
	</div>
	<div className='label'>
		<label>
		Loan Term (years):
		<input
			type="number"
			value={loanTerm}
			onChange={(e) => setLoanTerm(e.target.value)}
			placeholder='Loan Term'
		/>
		</label>
	</div>
	<div className='label'>
		<button onClick={calculateMonthlyPayment}>Calculate</button>
	</div>
	{error && <h3 className='res'>{error}</h3>}
	{monthlyPayment && (
		<div className='res'>
		<h3>Monthly Payment: ₹ {monthlyPayment}</h3>
		<h3>Total Loan Payment: ₹ {totalPayable}</h3>
		<h3>Total Interest Amount: ₹ {totalInterest}</h3>
		</div>
	)}
	</div>
	</div>
);
};

export default MortgageCalculator;
