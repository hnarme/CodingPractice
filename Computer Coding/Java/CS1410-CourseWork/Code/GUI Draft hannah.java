import java.awt.*;
import java.awt.event.*;

import javax.swing.*;
import javax.swing.border.*;

public class GUI {
	
	private JFrame mainFrame;

	public GUI (Numbercounterdata numc)
	{
//		final int blankSpace = 6; 
//		final double maxprice = 15.00;  if the price is set using a slider
//		final double minprice = 0;		if the price is set using a slider
//		final int maxtime = 1440;		if the time is set using a slider
//		final int mintime = 0;			if the time is set using a slider
		final int maxprobability = 1;  
		final int minprobability = 5;
		final int numChars = 10;
		
		JButton startButton = new JButton();
		JButton quitButton = new JButton();
		
		startButton.setText("Start Simulation");
		startButton.setToolTipText("This button start the simulation");
		
		quitButton.setText("Quit");
		quitButton.setToolTipText("This button quit application");

		final JLabel priceLabel = new JLabel("Price for gallons:");
		final JTextField priceEntry = new JTextField(numChars);
		
		final JLabel timeLabel = new JLabel("Period of time:");
		final JTextField timeEntry = new JTextField(numChars);
		
		final LabelledSlider shoppercentageSlider = new LabelledSlider("Shopping Percentage: ", minprobability, maxprobability, 1);
		
		//final JCheckBox gotItCheck = new JCheckBox("Browse shop");

		startButton.setMaximumSize(new Dimension(10, 10));
		quitButton.setMaximumSize(new Dimension(10, 10));
		priceEntry.setEditable(true);
		timeEntry.setEditable(true);
		shoppercentageSlider.setMajorTickSpacing(60);
		
		mainFrame = new JFrame("Gas Staition Simulator");
		mainFrame.setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);
		
		
		JPanel mainPanel = new JPanel();
		JPanel pricePanel = new JPanel();
		JPanel textPanel = new JPanel();
		JPanel timePanel = new JPanel();
		JPanel ScrollPanel = new JPanel(); 
		JPanel buttonPanel = new JPanel();
		
		pricePanel.setLayout(new FlowLayout());
		timePanel.setLayout(new FlowLayout());
		textPanel.setLayout(new BorderLayout());
		ScrollPanel.setLayout(new BorderLayout());
		mainPanel.setLayout(new BorderLayout());
		buttonPanel.setLayout(new FlowLayout());
		mainFrame.getContentPane().setLayout(new BorderLayout());
		
		
		pricePanel.add(priceLabel);
		pricePanel.add(priceEntry);
		
		timePanel.add(timeLabel);
		timePanel.add(timeEntry);
		
		textPanel.add(pricePanel, BorderLayout.NORTH);
		textPanel.add(timePanel, BorderLayout.EAST);
		
		ScrollPanel.add(shoppercentageSlider);
		
		mainPanel.add(textPanel, BorderLayout.WEST);
		mainPanel.add(ScrollPanel, BorderLayout.CENTER);
		
		buttonPanel.add(Box.createHorizontalGlue());
		buttonPanel.add(startButton);
		buttonPanel.add(quitButton);
		buttonPanel.add(Box.createHorizontalGlue());
		
		mainFrame.getContentPane().add(textPanel, BorderLayout.NORTH);
		mainFrame.getContentPane().add(buttonPanel, BorderLayout.SOUTH);
		

		
		mainFrame.addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				exitApp();
			}
		}); 
		
		quitButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				exitApp(); 
			}
		});
		
		startButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				exitApp(); //until the appropriate method is created
			}
		});
		

		
		mainFrame.pack();
		mainFrame.setVisible(true);
	}
	
	private void exitApp() {
		int response = JOptionPane.showConfirmDialog(mainFrame, 
				"Do you really want to quit?",
				"Quit?",
				JOptionPane.YES_NO_OPTION,
				JOptionPane.QUESTION_MESSAGE);
		if (response == JOptionPane.YES_OPTION) {
			System.exit(0);
		}
		
	}
}