
package com.sltc.soa.client.stub;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="accout_balance" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *         &lt;element name="withdraw_money" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "accoutBalance",
    "withdrawMoney"
})
@XmlRootElement(name = "WithdrawMoney")
public class WithdrawMoney {

    @XmlElement(name = "accout_balance")
    protected double accoutBalance;
    @XmlElement(name = "withdraw_money")
    protected double withdrawMoney;

    /**
     * Gets the value of the accoutBalance property.
     * 
     */
    public double getAccoutBalance() {
        return accoutBalance;
    }

    /**
     * Sets the value of the accoutBalance property.
     * 
     */
    public void setAccoutBalance(double value) {
        this.accoutBalance = value;
    }

    /**
     * Gets the value of the withdrawMoney property.
     * 
     */
    public double getWithdrawMoney() {
        return withdrawMoney;
    }

    /**
     * Sets the value of the withdrawMoney property.
     * 
     */
    public void setWithdrawMoney(double value) {
        this.withdrawMoney = value;
    }

}
